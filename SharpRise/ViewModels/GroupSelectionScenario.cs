using Guna.UI2.WinForms;
using Microsoft.IdentityModel.Tokens;
using SharpRise.Models.Users;
using SharpRise.View;
using Validator = SharpRise.Models.Security.Validator;

namespace SharpRise.ViewModels
{
    public partial class GroupSelectionScenario : Form
    {
        //TODO: Организовать сущности пользователей
        public GroupSelectionScenario()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(pgInviteCode);
        }

        private void btnIndependent_Click(object sender, EventArgs e)
        {
            Guna2MessageDialog msg = new Guna2MessageDialog();
            msg.Parent = this;
            msg.Caption = "Упс...";
            msg.Text = "В разработке";
            msg.Buttons = MessageDialogButtons.OK;
            msg.Style = MessageDialogStyle.Dark;
            msg.Show();
            msg.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(pgSelect);
            inputInviteCode1.Clear();
            inputInviteCode2.Clear();
        }

        // TextBox correction
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
            inputInviteCode2.Text = Models.Users.Group.GenerateInviteCode();
        }

        private void BtnEnter1_Click(object sender, EventArgs e)
        {
            string inviteCode = inputInviteCode1.Text;
            if (!Validator.ValidateInviteCode(inviteCode))
            {
                using var msg = new SharpRiseMessageDialog(this);
                msg.ShowError("Некорректный формат кода приглашения");
                return;
            }
            // TODO: Переход на main окно в качестве ученика
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(teacherReg);
        }

        private void btnEnter2_Click(object sender, EventArgs e)
        {
            string inviteCode = inputInviteCode1.Text;
            string groupName = inputGroupName.Text;

            using var msg = new SharpRiseMessageDialog(this);

            if (groupName.IsNullOrEmpty())
            {
                msg.ShowError("Введите имя группы");
                return;
            }

            if (!Validator.ValidateInviteCode(inviteCode))
            {
                // TODO: Починить (возвращает на правильный код неправильный результат)
                msg.ShowError("Некорректный формат кода приглашения");
                return;
            }

            //Group group = new Group();
            //group.Name = groupName;
            //group.IsVerificated = false;
            //group.Description = string.Empty;
            // TODO: Создание группы в БД 
            // TODO: Переход на main окно в качестве преподавателя
        }

        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            using var msg = new SharpRiseMessageDialog(this);

            DialogResult result = msg.AskQuestion("Вы уверены что хотите выйти из аккаунта?");

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
    }
}