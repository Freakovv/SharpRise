using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using SharpRise.src.Models.Entities;
using SharpRise.src.Models.Services;
using SharpRise.src.Models.Security;
using SharpRise.src.ViewModels;
using Validator = SharpRise.src.Models.Security.Validator;
using SharpRise.src.Models.Data;

namespace SharpRise.View
{
    public partial class SignUpWindow : Form
    {
        public SignUpWindow()
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

        private async void btnSignUp_ClickAsync(object sender, EventArgs e)
        {
            using var msg = new SharpRiseMessageDialog(this);

            if (inputEmail.Text.IsNullOrEmpty())
            {
                msg.ShowError("Введите Email");
                return;
            }
            if (inputUsername.Text.IsNullOrEmpty())
            {
                msg.ShowError("Введите имя пользователя");
                return;
            }                 
            if (inputPassword.Text.IsNullOrEmpty())
            {
                msg.ShowError("Введите пароль");
                return;
            }            
            if (inputRepeatPassword.Text.IsNullOrEmpty())
            {
                msg.ShowError("Введите пароль повторно");
                return;
            }            


            // Валидация email
            if (!Validator.IsValidEmail(inputEmail.Text))
            {
                msg.ShowError("Некорректный формат Email");
                return;
            }

            if(inputUsername.Text.Length < 3)
            {
                msg.ShowError("Слишком короткое имя пользователя");
                return;
            }

            if (inputPassword.Text != inputRepeatPassword.Text) {
                msg.ShowError("Пароли не совпадают");
                inputPassword.Clear();
                inputRepeatPassword.Clear();
                return;
            }
            
            // Валидация пароля
            var passwordValidation = Validator.ValidatePassword(inputPassword.Text);
            if (passwordValidation != null)
            {
                msg.ShowError(passwordValidation);
                return;
            }

            var user = new User
            {
                Email = inputEmail.Text,
                Username = inputUsername.Text,
                Password = Hasher.HashPassword(inputPassword.Text)
            };

            using var context = new ShariRiseContextFactory().CreateDbContext(null);
            var entityService = new EntityService(context);

            if (await entityService.EmailExistsAsync(inputEmail.Text))
            {
                msg.ShowError("Пользователь с таким email уже зарегистрирован");
                return;
            }

            // Переход
            GroupSelectionScenario selectionScenario = new GroupSelectionScenario(user);
            FadeAnimation fadeAnimation = new FadeAnimation(this);

            fadeAnimation.FadeOut();

            selectionScenario.Show();
            this.Hide();

            fadeAnimation.FormProperty = selectionScenario;
            fadeAnimation.FadeIn();
        }
    }
}
