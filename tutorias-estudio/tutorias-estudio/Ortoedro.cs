using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorias_estudio
{
    internal class Ortoedro
    {
        public Rectangulo[] laterales = new Rectangulo[4];
        public Cuadrado[] Bases = new Cuadrado[2];

        public Ortoedro(int anchoBase, int ladoComun, int largoLateral) 
        {
            Rectangulo ObjetoRectangulo = new Rectangulo(anchoBase,largoLateral);
            
        }
        
    }
}
