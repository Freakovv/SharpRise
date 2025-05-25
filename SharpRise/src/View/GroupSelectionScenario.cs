using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharpRise.src.Models.Data;
using SharpRise.src.Models.Entities;
using SharpRise.src.Models.Services;
using SharpRise.src.ViewModels;
using Validator = SharpRise.src.Models.Security.Validator;

namespace SharpRise.View
{
    public partial class GroupSelectionScenario : Form
    {
        private readonly User _user;

        public GroupSelectionScenario(User user)
        {
            _user = user;
            InitializeComponent();
        }


        #region Entity definition

        private async void btnIndependent_Click(object sender, EventArgs e)
        {
            var msg = new SharpRiseMessageDialog(this);

            try
            {
                using var entityService = EntityService.CreateEntityService();
                Student student = _user.ToStudent();
                await entityService.AddEntityAsync(student);

                msg.ShowInfo("Регистрация прошла успешно!", "Готово");
                // TODO: Transition to main
            }
            catch (DbUpdateException ex)
            {
                // DataBase Error
                msg.ShowError(
                    $"Ошибка базы данных: {ex.InnerException?.Message ?? ex.Message}",
                    "Ошибка регистрации"
                ); 
            }
            catch (Exception ex)
            {
                // Any other problem
                msg.ShowError(
                    $"Неизвестная ошибка: {ex.Message}",
                    "Ошибка"
                );
            }
        }
        private async void btnEnterTeacher_Click(object sender, EventArgs e)
        {
            using var msg = new SharpRiseMessageDialog(this);

            if (string.IsNullOrWhiteSpace(inputGroupName.Text))
            {
                msg.ShowError("Название группы обязательно для заполнения");
                return;
            }

            try
            {
                using var entityService = EntityService.CreateEntityService();

                var newTeacher = _user.ToTeacher();
                await entityService.AddEntityAsync(newTeacher);


                var newGroup = new Group
                {
                    Name = inputGroupName.Text,
                    TeacherUsername = newTeacher.Username,
                    IsVerificated = false,
                    CreationDate = DateTime.Now,
                    Teacher = newTeacher,
                    TeacherId = newTeacher.Id,
                    Description = string.Empty,
                    InviteCode = string.IsNullOrWhiteSpace(inputInviteCode2.Text)
                    ? Group.GenerateInviteCode()
                    : inputInviteCode2.Text
                };

                await entityService.AddEntityAsync(newGroup);

                msg.ShowInfo("Регистрация завершена");

                msg.ShowInfo($"Группа '{newGroup.Name}' успешно создана!");
                // TODO: Переход на главную форму
            }
            catch (DbUpdateException ex)
            {
                msg.ShowError($"Ошибка базы данных: {ex.InnerException?.Message ?? ex.Message}", "Ошибка");
            }
            catch (Exception ex)
            {
                msg.ShowError($"Неизвестная ошибка: {ex.Message}", "Ошибка");
            }
        }
        private async void btnEnterStudent_Click(object sender, EventArgs e)
        {
            string inviteCode = inputInviteCode1.Text;
            using var msg = new SharpRiseMessageDialog(this);

            // Валидация кода
            if (!Validator.ValidateInviteCode(inviteCode))
            {
                msg.ShowError("Некорректный формат кода приглашения");
                return;
            }

            try
            {
                using var entityService = EntityService.CreateEntityService();

                // Находим группу по коду
                var group = await entityService.GetGroupByInviteCodeAsync(inviteCode);
                if (group == null)
                {
                    msg.ShowError("Группа с таким кодом не найдена");
                    return;
                }

                // Создаем студента из User
                var student = _user.ToStudent(); 

                // Добавляем студента в БД
                await entityService.AddEntityAsync(student);

                // Добавляем студента в группу
                await entityService.AddStudentToGroupAsync(student.Id, group.Id);

                // Переход на главную форму
                msg.ShowInfo($"Вы успешно присоединились к группе {group.Name}!", "Готово");
                //this.Hide();
                //new MainForm(student).Show();
            }
            catch (DbUpdateException ex)
            {
                msg.ShowError($"Ошибка базы данных: {ex.InnerException?.Message ?? ex.Message}", "Ошибка");
            }
            catch (Exception ex)
            {
                msg.ShowError($"Неизвестная ошибка: {ex.Message}", "Ошибка");
            }
        }
        #endregion

        #region Transitions


        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(pgSelect);
            inputGroupName.Clear();
            inputInviteCode1.Clear();
            inputInviteCode2.Clear();
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