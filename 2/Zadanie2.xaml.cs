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

namespace _2
{
    /// <summary>
    /// Логика взаимодействия для Zadanie2.xaml
    /// </summary>
    public partial class Zadanie2 : Window
    {

        public static int indexImages = 0;

        public Zadanie2()
        {
            InitializeComponent();
        }
        private void NavigateToZadanie1(object sender, RoutedEventArgs e)
        {
            MainWindow zadanie1Window = new MainWindow();

            this.Close();

            zadanie1Window.Show();
        }
    }
}
