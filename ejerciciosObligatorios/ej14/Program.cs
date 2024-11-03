using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] perecederos = { "carne", "pan", "pecao" };
            string[] noPerecederos = { "legumbres", "miel", "cereal" };
            int cantProductos = 3;
            float total = 0;
            Random r = new Random();
            List<Producto> productos = new List<Producto>();
            for (int i = 0; i < cantProductos; i++)
            {
                productos.Add(new Perecedero(perecederos[i], r.Next(300, 501), r.Next(0, 6)));
                productos.Add(new NoPerecedero(noPerecederos[i], r.Next(300, 501), "type"));
            }
            foreach(Producto a in productos)
            {
                a.MostrarDetalles();
                Console.WriteLine($"{a.Calcular(productos)}");
                total += a.Calcular(productos);
            }
            Console.WriteLine("------");
            Console.WriteLine($"total: {total}");
            Console.ReadKey();
        }
    }
}
