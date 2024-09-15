using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] nums = { '0', '1', '2', '3','4','5','6','7','8', '9' };
            List<Espectador> espectadores = new List<Espectador>();
            List<Asiento> asientos = new List<Asiento>();
            Random r = new Random();
            Pelicula peliActual = new Pelicula("Shrek", 120, 6, "Dreamworks", 4500);
            Cine cine = new Cine(9, 8, peliActual);
            int aux = 0;

            for (int i = 0; i < cine.Columnas; i++)
            {
                for (int k = 0; k < cine.Filas; k++)
                {
                    aux++;
                    asientos.Add(new Asiento($"{letras[i]}{k} ", false));
                    espectadores.Add(new Espectador($"{aux}", r.Next(5, 81), r.Next(0, 10000)));
                }
            }
            foreach (Espectador e in espectadores) 
            {
                int seleccion = r.Next(0, cine.Filas*cine.Columnas);
                if (asientos[seleccion].Ocupado == false && e.Dinero >= peliActual.Precio && e.Edad >= peliActual.EdadMinima) //espectador.Butaca == null
                {
                    e.Butaca = asientos[seleccion];
                    asientos[seleccion].Ocupado = true;
                }
                else
                {
                    while (asientos[seleccion].Ocupado == true && e.Dinero >= peliActual.Precio && e.Edad >= peliActual.EdadMinima)
                    {
                        seleccion = r.Next(0, cine.Filas * cine.Columnas);
                        if (asientos[seleccion].Ocupado == false)
                        {
                            e.Butaca = asientos[seleccion];
                            asientos[seleccion].Ocupado = true;
                            break;
                        }
                    }
                }
                if (e.Butaca == asientos[seleccion])
                    Console.WriteLine($"El espectador {e.Nombre} está sentado en la butaca {asientos[seleccion].Etiqueta}");
                else
                    Console.WriteLine($"El espectador {e.Nombre} no pudo ingresar");
            }
            Console.ReadKey();
        }
    }
}
