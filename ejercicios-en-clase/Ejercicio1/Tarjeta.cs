using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Tarjeta
    {
        public int Num           
        {
            private set;
            get;
        }
        public double Saldo 
        {
            set;
            get;
        }
        public DateTime FechaIngreso
        {
            private set;
            get;
        }
        public DateTime FechaSalida
        {
            private set;
            get;
        }
        public Persona Dueño { get; set; }

        public Tarjeta(int num, string nombre, int dni) 
        {
            Dueño = new Persona(nombre, dni);
            FechaIngreso = DateTime.Today;
            FechaSalida = FechaIngreso.AddDays(2);
            Num = num;
        }
        public bool CargarJuego(double monto) 
        {
            bool result = false;
            if (Saldo > monto) 
            {
                Saldo -= monto;
                result = true;
            }
            return result;
        }

    }
}
