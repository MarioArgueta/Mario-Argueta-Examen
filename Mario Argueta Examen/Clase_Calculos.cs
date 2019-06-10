using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
namespace Mario_Argueta_Examen
{
    class Clase_Calculos : INotifyPropertyChanged
    {
        public string nombre;
        public string identidad;
        public string horasTrabajadas;
        public string pagoPorHora;
        public string horaExtra;
        public string iHSS;
        public string rAP;
        public string sueldoSinDeducciones;
        public string deducciones;
        public string sueltoTotal;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Identidad
        {
            get
            {
                return identidad;
            }
            set
            {
                identidad = value;
            }
        }
        public string HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set
            {
                int num;
                bool sueldoSinDeduccion
            }
        }
    }
}
