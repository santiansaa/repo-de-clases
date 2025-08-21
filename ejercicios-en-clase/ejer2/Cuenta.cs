using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    internal class Cuenta
    {
        public int Nro
        {
            get; set;
        }
        public string Moneda
        {
            get; set;
        }
        public double Saldo  
        {
            get; set;
        }
        public string Tipo { get; set; }
        public Cuenta(int nro, string moneda) 
        {
            Nro = nro; 
            Moneda = moneda;
        }

        

    }
}
