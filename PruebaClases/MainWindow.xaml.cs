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

namespace PruebaClases
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //DataContext (tipo Obj)
        Persona nuevo = new Persona();
        public MainWindow()
        {
            InitializeComponent();
            NombreTextBox.DataContext = nuevo;
            EdadTextBox.DataContext = nuevo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(nuevo.Nombre.ToString() + " "+ nuevo.Edad.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            nuevo.Edad++;
        }
    }
}
