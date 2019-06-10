using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
namespace Mario_Argueta_Examen
{
    class Clase_Empleado : INotifyPropertyChanged
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
                bool sueldoSinDeduccion = int.TryParse(value, out num);
                if (sueldoSinDeduccion) horasTrabajadas = value;
                OnPropertyChanged("HorasTrabajadas");
                OnPropertyChanged("SueldoSinDeducciones");
            }
        }
        public string PagoPorHora
        {
            get { return pagoPorHora; }
            set
            {
                int num;
                bool sueldoSinDeduccion = int.TryParse(value, out num);
                if (sueldoSinDeduccion) pagoPorHora = value;
                OnPropertyChanged("PagoPorHora");
                OnPropertyChanged("SueldoSinDeducciones");
            }
        }
        public string SueldoSinDeducciones
        {
            get
            {
                int sueldoSinDeducciones = int.Parse(HorasTrabajadas) * int.Parse(PagoPorHora);
                return sueldoSinDeducciones.ToString();
            }
            set
            {
                int multi = int.Parse(HorasTrabajadas) * int.Parse(PagoPorHora);
                SueldoSinDeducciones = multi.ToString();
            }
        }
        public string IHSS
        {
            get
            {
                int IHSS = int.Parse(SueldoSinDeducciones) * int.Parse("0.04");
                return IHSS.ToString();
            }
            set
            {
                int mult = int.Parse(SueldoSinDeducciones) * int.Parse("0.04");
                IHSS = mult.ToString();
            }
        }

    }
}
