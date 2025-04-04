using System;
using System.Threading.Tasks;
using System.Windows;
using SharpRise;
using SharpRise.ViewModels;
using WinFormsApp = System.Windows.Forms.Application;
using Microsoft.Extensions.Configuration;
using System.IO;
using MessageBox = System.Windows.MessageBox;
using System.Diagnostics;  

namespace SharpRiseIntegration
{
    public partial class App : System.Windows.Application
    {
        public IConfiguration? Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            if (!File.Exists("appsettings.json"))
            {
                ShowErrorConfig();
                Shutdown();
                return;
            }

            // Загрузка appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            base.OnStartup(e);

            SharpRise.ViewModelsWPF.SplashScreen splashScreen = new SharpRise.ViewModelsWPF.SplashScreen();
            splashScreen.Show();

            int splashScreenDelay = Configuration.GetValue<int>("AppSettings:SplashScreenDelay");
            Task.Run(() =>
            {
                Thread.Sleep(splashScreenDelay);

                this.Dispatcher.Invoke(() =>
                {
                    splashScreen.Close();
                    OpenMainForm();
                });
            });
        }

        // WinForms
        private void OpenMainForm()
        {
            WinFormsApp.EnableVisualStyles();
            WinFormsApp.SetCompatibleTextRenderingDefault(false);
            WinFormsApp.Run(new SignInWindow());
        }

        private static void ShowErrorConfig()
        {
            var dialog = new ErrorDialog();
            dialog.ShowDialog();
        }
    }
}