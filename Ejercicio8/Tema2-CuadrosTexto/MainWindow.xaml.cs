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

namespace Tema2_CuadrosTexto
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

        private void Comprobar_Tecla(object sender, KeyEventArgs e)
        {
            int x;
            if(e.Key == Key.F1 && Nombre.Text=="")
            {
                Nombre.Text = "Nombre del cliente";
                Apellido.Text = "Apellido del cliente";
            }
            else
            {


            if (e.Key == Key.F1 && Nombre.Text != "")
            {
                Nombre.Text = "";
                Apellido.Text = "";
            }
            }
            if (e.Key == Key.F2)
            {
                if (!int.TryParse(EdadCliente.Text, out x))
                {
                    ComprobarEdad.Text = "Edad Incorrecta";
                }
                else
                {
                    ComprobarEdad.Text = "Edad Correcta";
                }
            }
        }
    }
}
