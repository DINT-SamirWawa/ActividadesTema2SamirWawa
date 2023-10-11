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

namespace TEma2_CaracteresLimitados
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Texto.TextChanged += Texto_Observador;
            ActualizarContador();
        }

        private void Texto_Observador(object sender, TextChangedEventArgs e)
        {
            ActualizarContador(e);

            if (Texto.Text.Length > 140)
            {
                Texto.Text = Texto.Text.Substring(0, 140);
            }
        }

        private void ActualizarContador(TextChangedEventArgs e)
        {
            int caracteresRestantes = 140 - Texto.Text.Length;
            Contador.Text = $"Caracteres restantes: {caracteresRestantes}";
            if (caracteresRestantes < 0)
            {
                Texto.IsReadOnly = true;
            }
            else
            {
                Texto.IsReadOnly = false;
            }
        }
    }
}
