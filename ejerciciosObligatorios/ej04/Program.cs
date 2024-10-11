using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    internal class Program
    {
        private static readonly Random r = new Random();
        static void Main(string[] args)
        {
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];
            List<Lavadora> lavadoras = new List<Lavadora>();
            List<Television> televisiones = new List<Television>();
            double total = 0;
            for (int i = 0; i < 10; i++)
            {

                int siSale = r.Next(0, 3);
                if (siSale == 0)
                {
                    electrodomesticos[i] = new Television();
                    televisiones.Add((Television)electrodomesticos[i]);
                    Console.WriteLine($"El electrodomestico {i} es una televisión y tiene un precio final de: {electrodomesticos[i].PrecioFinal()}");
                }
                else if (siSale == 1)
                {
                    electrodomesticos[i] = new Lavadora();
                    lavadoras.Add((Lavadora)electrodomesticos[i]);
                    Console.WriteLine($"El electrodomestico {i} es una lavadora y tiene un precio final de: {electrodomesticos[i].PrecioFinal()}");
                }
                else
                {
                    electrodomesticos[i] = new Electrodomestico();
                    Console.WriteLine($"El electrodomestico {i} y tiene un precio final de: {electrodomesticos[i].PrecioFinal()}");
                }
            }

            Console.WriteLine("=================");

            Console.WriteLine("Televisiones");
            for (int i = 0; i < televisiones.Count; i++)
            {
                Console.WriteLine($"TV {i}: {televisiones[i].PrecioFinal()}");
            }

            Console.WriteLine("Lavadoras");
            for (int i = 0; i < lavadoras.Count; i++)
            {
                Console.WriteLine($"LV {i}: {lavadoras[i].PrecioFinal()}");
            }

            Console.WriteLine("Electrodomesticos varios");
            for (int i = 0; i < 10 ; i++)
            {
                if (!(electrodomesticos[i] is Television) && !(electrodomesticos[i] is Lavadora))
                {
                    Console.WriteLine($"ED {i}: {electrodomesticos[i].PrecioFinal()}");
                }
                total += electrodomesticos[i].PrecioFinal();
            }
            Console.WriteLine($"TOTAL: ${total}");
            Console.ReadKey();
        }
    }
}
