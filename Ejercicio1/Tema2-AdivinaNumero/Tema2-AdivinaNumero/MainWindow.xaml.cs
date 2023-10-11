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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int aleatorio;
        public MainWindow()
        {
            InitializeComponent();
            generaAleatorio();
        }
        private void generaAleatorio()
        {
            Random r = new Random();
            aleatorio = r.Next(101);
        }

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (aleatorio.ToString() == num.Text)
                SolucionTextBlock.Text = "Has acertado";
            else
                SolucionTextBlock.Text = "No has acertado";
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            num.Text = string.Empty;
            SolucionTextBlock.Text = string.Empty;
            generaAleatorio();
        }
    }
}
