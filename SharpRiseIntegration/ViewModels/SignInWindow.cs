using SharpRise.View;
using SharpRise.ViewModels;
using SharpRiseIntegration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;

namespace SharpRise
{
    internal partial class SignInWindow : Form
    {
        FadeAnimation animation;
        public SignInWindow()
        {
            InitializeComponent();
            animation = new FadeAnimation(this);
            animation.FadeIn();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow();
            FadeAnimation fadeAnimation = new FadeAnimation(this);

            fadeAnimation.FadeOut();

            signUpWindow.Show();
            this.Hide();

            fadeAnimation.FormProperty = signUpWindow;
            fadeAnimation.FadeIn();
        }
    }
}
