using System;
using System.Threading.Tasks;
using System.Windows;
using SharpRise;
using SharpRise.ViewModels;
using WinFormsApp = System.Windows.Forms.Application;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SharpRiseIntegration
{
    public partial class App : System.Windows.Application
    {
        public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            // Загрузка конфигурации из appsettings.json
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

        private void OpenMainForm()
        {
            WinFormsApp.EnableVisualStyles();
            WinFormsApp.SetCompatibleTextRenderingDefault(false);
            WinFormsApp.Run(new SignInWindow());
        }
    }
}