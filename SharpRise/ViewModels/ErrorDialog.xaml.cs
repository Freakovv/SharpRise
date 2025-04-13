using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;

namespace SharpRise.ViewModels
{
        public partial class ErrorDialog : Window
        {
            public ErrorDialog()
            {
                InitializeComponent();
            }

            private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = e.Uri.AbsoluteUri,
                        UseShellExecute = true
                    });
                    e.Handled = true;
                }
                catch
                {
                    System.Windows.MessageBox.Show("Не удалось открыть ссылку", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
}
