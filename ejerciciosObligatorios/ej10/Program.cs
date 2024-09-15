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
        static List<Mazo> mazos = new List<Mazo>();
        static List<Cartas> cartas = new List<Cartas>();
        static void Main(string[] args)
        {
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
            Mazo mazo = new Mazo(cartas);
            Console.ReadKey();
        }
    }
}   
