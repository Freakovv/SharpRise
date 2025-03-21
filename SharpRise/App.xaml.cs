using System;
using System.Threading.Tasks;
using System.Windows;
using SharpRise;
using WinFormsApp = System.Windows.Forms.Application;

namespace SharpRiseIntegration
{
    public partial class App : System.Windows.Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ViewModelsWPF.SplashScreen splashScreen = new ViewModelsWPF.SplashScreen();
            splashScreen.Show();

            // Запускаем асинхронную задачу для загрузки данных или выполнения других операций
            Task.Run(() =>
            {
                // Имитация загрузки
                Thread.Sleep(3000); 

                // Закрываем SplashScreen и открываем WinForms-форму
                this.Dispatcher.Invoke(() =>
                {
                    splashScreen.Close();
                    OpenMainForm();
                });
            });
        }

        private void OpenMainForm()
        {
            // Запуск WinForms-формы
            WinFormsApp.EnableVisualStyles();
            WinFormsApp.SetCompatibleTextRenderingDefault(false);
            WinFormsApp.Run(new SignInWindow());
        }
    }
}