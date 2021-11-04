using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClases
{
    class Persona : INotifyPropertyChanged
    {
        //propfull
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                //"Nombre" = nombre de la propiedad que está cambiando
                NotifyPropertyChanged("Nombre");
            }
        }

        private int _edad;

        public int Edad
        {
            get { return _edad; }
            set
            {
                _edad = value;
                NotifyPropertyChanged("Edad");
            }
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public Persona()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
