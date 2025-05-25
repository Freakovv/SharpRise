using ICSharpCode.AvalonEdit.Highlighting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SharpRise.src.View.MainWindow.Student
{
    /// <summary>
    /// Логика взаимодействия для CodeEditorPage.xaml
    /// </summary>
    public partial class CodeEditorPage : Page
    {
        public CodeEditorPage()
        {
            InitializeComponent();

            // Дополнительная настройка редактора
            CodeEditor.ShowLineNumbers = true;
            CodeEditor.Options.HighlightCurrentLine = true;
            CodeEditor.TextArea.TextView.LineTransformers.Add(
                new HighlightingColorizer(HighlightingManager.Instance.GetDefinition("C#")));
        }

        private void OnSubmitClick(object sender, RoutedEventArgs e)
        {
            string code = CodeEditor.Text;
            // Обработка отправки кода
            System.Windows.MessageBox.Show($"Код отправлен:\n\n{code}");
        }
    }
}
