using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Persona
    {
        private string nombre;
        private int dni;
        DateTime fechanacimiento;

        public string Nombre { get; set; }
        public int Dni { get; set; }




        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        public string Datos() 
        {
            return $"{nombre} - {dni}";
        }

    }
}
