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
        Persona personaka = new Persona("Irene", 21);
        public MainWindow()
        {
            InitializeComponent();

            NombreTextBox.DataContext = personaka;
            EdadTextBox.DataContext = personaka;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(personaka.Nombre.ToString() + " "+ personaka.Edad.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            personaka.Edad++;
        }
    }
}
