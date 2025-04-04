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
    internal class SharpRiseMessageDialog : Guna2MessageDialog
    {

        internal SharpRiseMessageDialog(Form parent)
        {
            Parent = parent;
            Caption = "SharpRise";
            Style = MessageDialogStyle.Dark;
        }

        ~SharpRiseMessageDialog()
        {
            Dispose();
        }

        public void ShowWarning(string text, string caption="Внимание")
        {
            Icon = MessageDialogIcon.Warning;
            Caption = caption;
            Text = text;
            Buttons = MessageDialogButtons.OK;
            Show();
        }

        public void ShowWarning()
        {
            Icon = MessageDialogIcon.Warning;
            Buttons = MessageDialogButtons.OK;
            Show();
        }

        public void ShowError(string text, string caption="Ошибка")
        {
            Icon = MessageDialogIcon.Error;
            Caption = caption;
            Text = text;
            Buttons = MessageDialogButtons.OK;
            Show();
        }

        public void ShowError()
        {
            Icon = MessageDialogIcon.Error;
            Buttons = MessageDialogButtons.OK;
            Show();
        }

        public DialogResult AskQuestion(string text, string caption = "Вопрос")
        {
            Icon = MessageDialogIcon.Question;
            Caption = caption;
            Text = text;
            Buttons = MessageDialogButtons.YesNo;

            return Show();
        }

        public DialogResult AskQuestion()
        {
            Icon = MessageDialogIcon.Question;
            Buttons = MessageDialogButtons.YesNo;
            return Show();
        }

        public void ShowInfo(string text, string caption="Информация")
        {
            Icon = MessageDialogIcon.Information;
            Caption = caption;
            Text = text;
            Buttons = MessageDialogButtons.OK;
            Show();
        }

        public void ShowInfo()
        {
            Icon = MessageDialogIcon.Information;
            Buttons = MessageDialogButtons.OK;
            Show();
        }
    }
}
