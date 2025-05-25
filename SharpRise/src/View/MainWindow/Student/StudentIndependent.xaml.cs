using SharpRise.src.ViewModels;
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
using System.Windows.Shapes;
using SharpRise.src.View.MainWindow.Student.Pages;

namespace SharpRise.src.View.MainWindow
{
    /// <summary>
    /// Логика взаимодействия для StudentIndependent.xaml
    /// </summary>
    public partial class StudentIndependent : Window
    {
        public StudentIndependent()
        {
            InitializeComponent();
            LoadKataPage();
        }

        private void LoadKataPage()
        {
            var kataPage = new KataPage();
            kataPage.DataContext = new KataViewModel();
            MainContentFrame.Navigate(kataPage);
        }
    }
}
