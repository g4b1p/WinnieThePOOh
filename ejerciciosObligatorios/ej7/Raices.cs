using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ej7
{
    internal class Raices
    {
        int a;
        int b;
        int c;

        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
        public int C { get { return c; } set { c = value; } }
        public Raices(int Aa, int Bb, int Cc)
        {
            A = Aa;
            B = Bb;
            C = Cc;
        }

        public void ObtenerRaices()
        {
            //(-B √((B ^ 2) - (4 * A * C)))/ (2 * A);       profe ayuda
        }
        public void ObtenerRaiz()
        {
            // profe ayuda
        }
        public double GetDiscriminante()
        {
            return (B ^ 2) - 4 * A * C;
        }
        public bool TieneRaices()
        {
            if (GetDiscriminante() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Calcular()
        {

        }
    }
}
