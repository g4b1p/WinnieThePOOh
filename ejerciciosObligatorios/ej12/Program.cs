using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>();
            for (int i = 1; i <= 6; i++)
            {
                jugadores.Add(new Jugador(i));
            }
            Random random = new Random();
            Revolver revolver = new Revolver(random.Next(1, 6), random.Next(1, 6));

            Juego juego = new Juego(jugadores, revolver);
            juego.Ronda();

            Console.ReadKey();
        }
    }
}
