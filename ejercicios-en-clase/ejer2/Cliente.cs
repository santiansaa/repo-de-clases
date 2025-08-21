using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ejer2
{
    internal class Cliente
    {
        ArrayList cuentas = new ArrayList();
        public int Nro
        {
            get; set;
        }
        public long Cuit
        {
            get; set;
        }
        public Cliente(long cuit)
        {
            Cuit = cuit;
            Nro = 1000;
        }
        public void CrearCuenta(string tipo, string moneda)
        {
            Cuenta nueva = new Cuenta(Nro++, moneda);
            nueva.Tipo = tipo;
            cuentas.Add(nueva);
        }

        public Cuenta VerCuenta(int numero)
        {
            Cuenta encontrada = null;
            int c = 0;
            while (encontrada != null && c < cuentas.Count)
            {
                if (((Cuenta)cuentas[c]).Nro == numero)
                {
                    encontrada = (Cuenta)cuentas[c];
                    c++;
                }

            }
            return encontrada;
        }
        public ArrayList ListaDeCuentas() 
        {
            ArrayList lista = new ArrayList();
            foreach (Cuenta c in cuentas) 
            {
                lista.Add(c.Nro + " " + c.Tipo + " " + c.Moneda);
            }
            return lista;
        }
    }
}
