using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Electrodomesticos[] electrodomesticos = {};
            List<Electrodomesticos> electrodomesticos = new List<Electrodomesticos>();

            Lavadora lav1 = new Lavadora();
            Lavadora lav2 = new Lavadora();
            Lavadora lav3 = new Lavadora();
            Lavadora lav4 = new Lavadora();
            Lavadora lav5 = new Lavadora();
            electrodomesticos.Add(lav1);
            electrodomesticos.Add(lav2);
            electrodomesticos.Add(lav3);
            electrodomesticos.Add(lav4);
            electrodomesticos.Add(lav5);

            Television tv1 = new Television();
            Television tv2 = new Television();
            Television tv3 = new Television();
            Television tv4 = new Television();
            Television tv5 = new Television();
            electrodomesticos.Add(tv1);
            electrodomesticos.Add(tv2);
            electrodomesticos.Add(tv3);
            electrodomesticos.Add(tv4);
            electrodomesticos.Add(tv5);

            double prElects = 0;
            foreach(Electrodomesticos elec in electrodomesticos)
            {
                elec.PrecioFinal();
                prElects += elec.PrecioBase;
            }
            Console.WriteLine(prElects);
            Console.ReadKey();
        }
    }
}
