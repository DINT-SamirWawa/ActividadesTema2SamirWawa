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

namespace Tema2_CalculadoraBasica
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

        private void CalcularBotton_Click(object sender, RoutedEventArgs e)
        {
            int num = 0;
            switch (Operador.Text)
            {
                case "+":
                    num = int.Parse(Operando1.Text) + int.Parse(Operando2.Text);
                    break;
                case "-":
                    num = int.Parse(Operando1.Text) - int.Parse(Operando2.Text);
                 break;
                case "*":
                    num = int.Parse(Operando1.Text) * int.Parse(Operando2.Text);
                break;
                case "/":
                    num = int.Parse(Operando1.Text) / int.Parse(Operando2.Text);
                break;
                default: 
                    throw new Exception();
            }
            Resultado.Text = num.ToString(); 
        }

        private void LimpiarBotton_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = string.Empty;
            Operador.Text = string.Empty;
            Operando1.Text = string.Empty;
            Operando2.Text = string.Empty;
        }

        private void Esc_Limpiar(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
                LimpiarBotton_Click(sender, e);
        }
    }
}
