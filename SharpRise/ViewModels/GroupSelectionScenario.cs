using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SharpRise.View;

namespace SharpRise.ViewModels
{
    public partial class GroupSelectionScenario : Form
    {
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

        private void btnCancelJoin_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(pgSelect);
            inputInviteCode.Clear();
        }
    }
}
