using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej09
{
    internal class Asiento
    {
        string etiqueta;
        bool ocupado;

        public string Etiqueta { get { return etiqueta; } set { etiqueta = value; } }
        public bool Ocupado { get { return ocupado; } set { ocupado = value; } }

        public Asiento(string etiqueta, bool ocupado)
        {
            this.etiqueta = etiqueta;
            this.ocupado = ocupado;
        }
    }
}