using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ej06
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Libro> list = new List<Libro>();
            list.Add(new Libro(29029891831233, "El visitante", "Stephen King", 592));
            list.Add(new Libro(12901290930390, "IT", "Stephen King", 1504));

            Libro aux = new Libro();
            foreach (Libro l in list)
            { 
                l.MostrarDetalles();
                if (l.NumPaginas > aux.NumPaginas)
                {
                    aux.NumPaginas = l.NumPaginas;
                    aux.Titulo = l.Titulo;
                }
            }
            Console.WriteLine($"El libro con más paginas es {aux.Titulo}");
            Console.ReadKey();
        }
    }
}
