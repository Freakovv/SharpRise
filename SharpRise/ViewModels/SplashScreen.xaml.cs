using System.Windows;
using System.Windows.Media.Animation;

namespace SharpRise.ViewModelsWPF
{
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard fadeIn = (Storyboard)FindResource("FadeInAnimation");
            fadeIn.Begin(this);
        }
    }
}
