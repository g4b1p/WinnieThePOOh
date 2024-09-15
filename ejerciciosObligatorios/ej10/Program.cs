using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mazo> mazos = new List<Mazo>();
            List<Cartas> cartas = new List<Cartas>();

            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 12; k++)
                {
                    if (k != 8 && k != 9)
                    {
                        if (i == 0)
                            cartas.Add(new Cartas(k, "oro"));
                        else if (i == 1)
                            cartas.Add(new Cartas(k, "copa"));
                        else if (i == 2)
                            cartas.Add(new Cartas(k, "espada"));
                        else
                            cartas.Add(new Cartas(k, "basto"));
                    }
                }
            }

            Mazo mazo = new Mazo(new List<Cartas>(cartas));
            Mazo mazo2 = new Mazo(new List<Cartas>(cartas));
            mazo.Barajar(cartas);
            mazo2.MostrarDetalles(cartas);
            Console.ReadKey();
        }
    }
}   
