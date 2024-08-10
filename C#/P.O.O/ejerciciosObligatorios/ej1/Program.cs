using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            Cuenta c1 = new Cuenta("Sebastian Yatra", 1209);
            cuentas.Add(c1);
            Cuenta c2 = new Cuenta("Sundar Pichai", 9405);
            cuentas.Add(c2);
            Cuenta c3 = new Cuenta("Carla Mendoza", 6388);
            cuentas.Add(c3);


        }
    }
}
