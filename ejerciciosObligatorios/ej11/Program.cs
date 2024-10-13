using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>();
            for (int i = 1; i <= 5; i++)
            {
                jugadores.Add(new Jugador(i, rnd.Next(500, 1001)));
            }

            string[] equipos = { "San Lorenzo", "Huracan", "Boca", "River", "Independiente", "Racing", "Velez", "SacaChispas", "Los Andes" }; 
            Partido partido = new Partido(equipos);

            Juego juego = new Juego(jugadores, partido);

            juego.Ronda(rnd);


            Console.ReadKey();
        }
    }
}
