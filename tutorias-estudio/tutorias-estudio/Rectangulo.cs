using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorias_estudio
{
    internal class Rectangulo
    {
        public int ancho ;
        public int largo ;

        public Rectangulo(int ancho, int largo) 
        {
            this.ancho = ancho;
            this.largo = largo;     

        }
        public void CalcularArea() 
        {
            int area = ancho * largo;
                       
        }
        public void Describir() 
        {
            string json = @"['Tipo':Rectangulo ]";
        }

    }
}
