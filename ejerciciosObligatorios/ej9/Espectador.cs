using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ej09
{
    internal class Espectador
    {
        string nombre = "Juan";
        int edad;
        double dinero;
        Asiento butaca;

        public string Nombre { get { return nombre; } set { nombre= value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public double Dinero { get{ return dinero; } set{ dinero = value; } }
        public Asiento Butaca { get { return butaca; } set { butaca = value; } }

        public Espectador(int edad, double dinero)
        {
            this.edad = edad;
            this.dinero = dinero;
        }

        public Espectador(string nombre, int edad, double dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }
    }
}