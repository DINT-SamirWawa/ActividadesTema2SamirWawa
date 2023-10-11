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

namespace Tema2_Imagen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Opacidad_Media(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 0.6;
        }

        private void Opacidad_Alta(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 1;
        }

        private void Opacidad_Baja(object sender, RoutedEventArgs e)
        {
            Imagen.Opacity = 0.3;
        }

        private void Ajuste_Relleno(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.Fill;
        }

        private void Ajuste_Uniforme(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.Uniform;
        }

        private void Ajuste_RellenoUniforme(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.UniformToFill;
        }

        private void Ajuste_None(object sender, RoutedEventArgs e)
        {
            Imagen.Stretch = Stretch.None;
        }
    }
}
