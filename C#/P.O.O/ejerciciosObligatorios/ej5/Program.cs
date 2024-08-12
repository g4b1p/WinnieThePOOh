using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Serie> series = new List<Serie>();
            List<Videojuego> juegos = new List<Videojuego>();

            Serie s1 = new Serie();
            Serie s2 = new Serie();
            Serie s3 = new Serie();
            Serie s4 = new Serie();
            Serie s5 = new Serie();
            series.Add(s1);
            series.Add(s2);
            series.Add(s3);
            series.Add(s4);
            series.Add(s5);

            Videojuego j1 = new Videojuego();
            Videojuego j2 = new Videojuego();
            Videojuego j3 = new Videojuego();
            Videojuego j4 = new Videojuego();
            Videojuego j5 = new Videojuego();
            juegos.Add(j1);
            juegos.Add(j2);
            juegos.Add(j3);
            juegos.Add(j4);
            juegos.Add(j5);

            s4.Entregar();
            s1.Entregar();
            j3.Entregar();
            j5.Entregar();

            int cantL = 0;
            int cantV = 0;
            foreach(Serie s in series)
            {
                if (s.IsEntregado() == true)
                {
                    cantL++;
                    s.Devolver();
                }
            }
            foreach (Videojuego v in juegos)
            {
                if (v.IsEntregado() == true)
                {
                    cantL++;
                    v.Devolver();
                }
            }

            //falta el CompareTo (preguntar al profe)
        }
    }
}
