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
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                int siSale = r.Next(0, 2);
                if (siSale == 0)
                    electrodomesticos[i] = new Television();
                else
                    electrodomesticos[i] = new Lavadora();

                Console.WriteLine($"El electrodomestico tiene un precio final de: {electrodomesticos[i].PrecioFinal()}");
            }
            Console.ReadKey();
        }
    }
}
