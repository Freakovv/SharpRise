using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpRise.Models.Users;
using SharpRise.View;

namespace SharpRise.ViewModels
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Transition
            GroupSelectionScenario selectionScenario = new GroupSelectionScenario();
            FadeAnimation fadeAnimation = new FadeAnimation(this);

            fadeAnimation.FadeOut();

            selectionScenario.Show();
            this.Hide();

            fadeAnimation.FormProperty = selectionScenario;
            fadeAnimation.FadeIn();
        }
    }
}
