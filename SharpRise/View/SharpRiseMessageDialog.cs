using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;

namespace SharpRise.View
{
    // This is a custom dialog message class, created to reduce extra code
    public class SharpRiseMessageDialog : Guna2MessageDialog
    {

        internal SharpRiseMessageDialog(Form parent)
        {
            this.Parent = parent;
            this.Caption = "SharpRise";
            this.Style = MessageDialogStyle.Dark;
        }

        ~SharpRiseMessageDialog()
        {
            
            Dispose();
        }

        public void ShowWarning(string text, string caption="Внимание")
        {
            this.Icon = MessageDialogIcon.Warning;
            this.Caption = caption;
            this.Text = text;
            this.Buttons = MessageDialogButtons.OK;
            this.Show();
        }

        public void ShowWarning()
        {
            this.Icon = MessageDialogIcon.Warning;
            this.Buttons = MessageDialogButtons.OK;
            this.Show();
        }

        public void ShowError(string text, string caption="Ошибка")
        {
            this.Icon = MessageDialogIcon.Error;
            this.Caption = caption;
            this.Text = text;
            this.Buttons = MessageDialogButtons.OK;
            this.Show();
        }

        public void ShowError()
        {
            this.Icon = MessageDialogIcon.Error;
            this.Buttons = MessageDialogButtons.OK;
            this.Show();
        }

        public void AskQuestion(string text, string caption="Вопрос")
        {
            this.Icon = MessageDialogIcon.Question;
            this.Caption = caption;
            this.Text = text;

            this.Show();
        }

        public void AskQuestion()
        {
            this.Icon = MessageDialogIcon.Question;
            this.Buttons = MessageDialogButtons.YesNo;
            this.Show();
        }

        public void ShowInfo(string text, string caption="Информация")
        {
            this.Icon = MessageDialogIcon.Information;
            this.Caption = caption;
            this.Text = text;
            this.Buttons = MessageDialogButtons.OK;
            this.Show();
        }

        public void ShowInfo()
        {
            this.Icon = MessageDialogIcon.Information;
            this.Buttons = MessageDialogButtons.OK;
            this.Show();
        }
    }
}
