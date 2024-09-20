using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    internal class Jugador
    {
        string nombre;
        int dinero;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Dinero { get { return dinero; } set {dinero = value; } }
        Jugador(string nombre, int dinero) { this.nombre = nombre; this.dinero = dinero; }
    }
}
