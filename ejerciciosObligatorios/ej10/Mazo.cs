using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    internal class Mazo
    {
        List<Cartas> cartas;

        public List<Cartas> Cartas { get { return cartas; } set { cartas = value; } }

        public Mazo(List<Cartas> C) 
        { 
            cartas = C;
        }
    }
}
