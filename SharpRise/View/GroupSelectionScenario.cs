using Guna.UI2.WinForms;
using Microsoft.IdentityModel.Tokens;
using SharpRise.Models.Data;
using SharpRise.Models.Users;
using SharpRise.View;
using System.Windows.Interop;
using Validator = SharpRise.Models.Security.Validator;

namespace SharpRise.ViewModels
{
    public partial class GroupSelectionScenario : Form
    {
        User User { get; set; }
        Teacher? teacher { get; set; }
        Student? student { get; set; }
        Group? Group { get; set; }

        public GroupSelectionScenario(User user)
        {
            this.User = user;
            InitializeComponent();
        }


        #region Entity definition

        private void btnIndependent_Click(object sender, EventArgs e)
        {
            //var student = new Student
            //{
            //    Email = User.Email,
            //    Username = User.Email,
            //    Password = User.Password,
            //};
            // TODO: добавление в бд
            // TODO: переход на main
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(pgInviteCode);
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(teacherReg);
        }
        #endregion

        #region Transitions
        private void BtnEnter1_Click(object sender, EventArgs e)
        {
            string inviteCode = inputInviteCode1.Text;
            if (!Validator.ValidateInviteCode(inviteCode))
            {
                using var msg = new SharpRiseMessageDialog(this);
                msg.ShowError("Некорректный формат кода приглашения");
                return;
            }



            // TODO: Переход на main-форму группового обучения (студент)
        }

        private void btnEnter2_Click(object sender, EventArgs e)
        {
            string inviteCode = inputInviteCode2.Text;
            string groupName = inputGroupName.Text;

            using var msg = new SharpRiseMessageDialog(this);

            // checking null or empty strings
            if (groupName.IsNullOrEmpty())
            {
                msg.ShowError("Введите имя группы");
                return;
            }
            
            if (!inviteCode.IsNullOrEmpty())
            {
                if (inviteCode.Length != 9)
                {
                    msg.ShowError("Введите код полностью");
                    return;
                }

                // general validation invite code
                if (!Validator.ValidateInviteCode(inviteCode))
                {
                    msg.ShowError("Некорректный формат кода приглашения.\nФормат: XXXX-9999 (4 буквы, '-', 4 цифры)");
                    return;
                }
                // TODO: Создание группы в БД 
            }

            // TODO: Переход на main-форму группового обучения (преподаватель)
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(pgSelect);
            inputGroupName.Clear();
            inputInviteCode1.Clear();
            inputInviteCode2.Clear();
        }

        #endregion

        #region Head buttons
        private void btnExit_Click(object sender, EventArgs e)
        {
            using var msg = new SharpRiseMessageDialog(this);
            DialogResult result = msg.AskQuestion("Это отменит регистрацию и удалит все ваши данные", "Вы уверены что хотите закрыть приложение?");

            if (result == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            using var msg = new SharpRiseMessageDialog(this);

            DialogResult result = msg.AskQuestion("Это отменит регистрацию и удалит все ваши данные", "Вы уверены что хотите выйти из аккаунта?");

            if (result == DialogResult.Yes)
            {
                var window = new SignInWindow();
                FadeAnimation fadeAnimation = new FadeAnimation(this);

                fadeAnimation.FadeOut();

                window.Show();
                this.Hide();

                fadeAnimation.FormProperty = window;
                fadeAnimation.FadeIn();
            }
        }

        #endregion



        #region View corrections
        private void InputInviteCode_TextChanged(object sender, EventArgs e)
        {
            // For Students
            string text1 = inputInviteCode1.Text.Replace(" ", "").Replace("-", "");

            if (text1.Length > 4)
            {
                text1 = text1.Insert(4, "-");
            }

            inputInviteCode1.Text = text1;

            inputInviteCode1.SelectionStart = inputInviteCode1.Text.Length;

            // For Teachers
            string text2 = inputInviteCode2.Text.Replace(" ", "").Replace("-", "");

            if (text2.Length > 4)
            {
                text2 = text2.Insert(4, "-");
            }

            inputInviteCode2.Text = text2;

            inputInviteCode2.SelectionStart = inputInviteCode2.Text.Length;
        }
        private void BtnGenerateCode_Click(object sender, EventArgs e)
        {
            inputInviteCode2.Text = Group.GenerateInviteCode();
        }
        #endregion

    }
}