using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
using static _2.MainWindow;

namespace _2
{
    /// <summary>
    /// Логика взаимодействия для Images.xaml
    /// </summary>
    public partial class Images : UserControl
    {
        private double rotationAngle = 0;
        public Images()
        {
            InitializeComponent();
        }
        private void WrapPanel_Loaded(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "https://kakogo-chisla.ru/wp-content/uploads/2022/06/Den-fotografii-prirody-2048x1363.jpg";
            Zadanie2.indexImages++;
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            rotationAngle += 90;
            ApplyRotation();
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            rotationAngle -= 90;
            ApplyRotation();
        }

        private void ApplyRotation()
        {
            RotateTransform rotateTransform = new RotateTransform(rotationAngle);
            image1.RenderTransform = rotateTransform;
        }

    }
}
