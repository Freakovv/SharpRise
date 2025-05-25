using SharpRise.src.View.MainWindow.Student;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpRise.src.ViewModels
{
    public class KataViewModel
    {
        public ObservableCollection<Kata> Katas { get; set; }

        public KataViewModel()
        {
            Katas = new ObservableCollection<Kata>
        {
            new Kata
            {
                Title = "Multiply",
                Description = "This kata is about multiplying a given number by eight...",
                Kyu = "8 kyu",
                Language = "C#"
            },
            new Kata
            {
                Title = "Even or Odd",
                Description = "Create a function that takes an integer as an argument...",
                Kyu = "8 kyu",
                Language = "JavaScript"
            },
            // Добавьте больше задач по мере необходимости
        };
        }
    }
}
