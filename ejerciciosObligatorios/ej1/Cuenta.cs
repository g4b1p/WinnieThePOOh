using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    public class Cuenta
    {
        string titular;
        double cantidad = 1000;

        public string Titular { get { return titular; } set { titular = value; } }
        public double Cantidad { get { return cantidad; } set { cantidad = value; } }

        public Cuenta(string T)
        {
            titular = T;
        }
        public Cuenta(string T, double C)
        {
            titular = T;
            cantidad = C;
        }
        public string GetTitular()
        {
            return titular;
        }

        public void SetTitular(string titular)
        {
            this.titular = titular;
        }
        public double GetCantidad()
        {
            return cantidad;
        }
        public void SetCantidad(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public void Ingresar(double cant)
        {
            if (cant >= 0) { 
                cantidad += cant;
            }
        }
        public void Retirar(double cant)
        {
            cantidad -= cant;
            if (cantidad < 0)
            {
                cantidad = 0;
            }
        }
    }
}
