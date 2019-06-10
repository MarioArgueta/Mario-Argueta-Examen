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
        public string pagoHoraExtra;
        public string sueldoHorasExtra;
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
        public string RAP
        {
            get
            {
                int RAP = int.Parse(SueldoSinDeducciones) * int.Parse("0.035");
                return RAP.ToString();
            }
            set
            {
                int multx = int.Parse(SueldoSinDeducciones) * int.Parse("0.035");
                RAP = multx.ToString();
            }
        }
        public string PagoHoraExtra
        {
            get { return pagoHoraExtra; }
            set
            {
                int num;
                bool SueldoHoraExtra = int.TryParse(value, out num);
                if (SueldoHoraExtra) pagoHoraExtra = value;
                OnPropertyChanged("PagoHoraExtra");
                OnPropertyChanged("SueldoHoraExtra");
            }
        }
        public string HorasExtra
        {
            get { return horaExtra; }
            set
            {
                int num;
                bool SueldoHoraExtra = int.TryParse(value, out num);
                if (SueldoHoraExtra) pagoHoraExtra = value;
                OnPropertyChanged("HoraExtra");
                OnPropertyChanged("SueldoHoraExtra");
            }
        }
        public string SueldoHorasExtra
        {
            get
            {
                int sueldoHorasExtra = int.Parse(HorasExtra) * int.Parse(PagoHoraExtra);
                return sueldoHorasExtra.ToString();
            }
            set
            {
                int multip = int.Parse(HorasExtra) * int.Parse(PagoHoraExtra);
                SueldoHorasExtra = multip.ToString();
            }
        }
        public string Deducciones
        {
            get
            {
                int deducciones = int.Parse(SueldoSinDeducciones) - (int.Parse(IHSS) + int.Parse(RAP));
                return sueldoHorasExtra.ToString();
            }
            set
            {
                int rest = int.Parse(SueldoSinDeducciones) - (int.Parse(IHSS) + int.Parse(RAP));
                SueldoHorasExtra = rest.ToString();
            }
        }
        public string SueldoTotal
        {
            get
            {
                int sueldoTotal = int.Parse(SueldoSinDeducciones) - int.Parse(Deducciones);
                return sueldoTotal.ToString();
            }
            set
            {
                int resta = int.Parse(SueldoSinDeducciones) - int.Parse(Deducciones);
               SueldoTotal = resta.ToString();
            }
        }
    }
}
