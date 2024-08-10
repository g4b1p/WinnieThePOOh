using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    public class Cuenta
    {
        string titular;
        double cantidad;

        public string Titular { get { return titular; } set { titular = value; } }
        public double Cantidad { get { return cantidad; } set { cantidad = value; } }

        public Cuenta(string T)
        {
            this.Titular = T;
        }
        public Cuenta(string T, double C)
        {
            this.Titular = T;
            this.Cantidad = C;
        }
        public void Ingresar(double cant)
        {
            if (cant >= 0) { 
                Cantidad += cant;
            }
        }
        public void Retirar(double cant)
        {
            Cantidad -= cant;
            if (Cantidad < 0)
            {
                Cantidad = 0;
            }
        }
    }
}
