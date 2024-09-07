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

            Serie s1 = new Serie("Madoka Magica", 3, "Mahou Shoujo", "Gen Urobochi");
            Serie s2 = new Serie("Higurashi", 2, "Psycho","Ryukishi07");
            Serie s3 = new Serie("Umineko", 2, "Murder Mystery", "Ryukishi07");
            Serie s4 = new Serie("Evangelion", 1, "Shounen", "Hideaki Anno");
            Serie s5 = new Serie("Lain", 1, "Phylo", "Yoshitoshi Abe");
            series.Add(s1);
            series.Add(s2);
            series.Add(s3);
            series.Add(s4);
            series.Add(s5);

            Videojuego j1 = new Videojuego("Undertale", 6, "RPG", "Toby Fox");
            Videojuego j2 = new Videojuego("Dying Light", 30, "Zombie Parkour RPG", "Techland");
            Videojuego j3 = new Videojuego("Yume Nikki", 5, "Puzzle", "kikiyama");
            Videojuego j4 = new Videojuego("Lobotomy Corporation", 10, "Management", "Project Moon");
            Videojuego j5 = new Videojuego("Watch Dogs", 30, "Open World", "Ubisoft");
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
            Serie lSerie;
            for (int i = 0; i < series.Count; i++)
            {
                if (series[i].IsEntregado() == true)
                {
                    cantL++;
                    series[i].Devolver();
                }
                if (i < series.Count)
                {
                    if (series[i].CompareTo(series[i + 1]) == 1)
                    {
                       lSerie = series[i];
                    }
                }
                else
                {
                    lSerie.ToString();
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

            
        }
    }
}
