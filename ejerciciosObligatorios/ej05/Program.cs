using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Serie> series = new List<Serie>();
            List<Videojuego> juegos = new List<Videojuego>();
            series.Add(new Serie("Madoka Magica", 5, "Mahou Shoujo", "Gen Urobochi"));
            series.Add(new Serie("Higurashi", 2, "Psycho", "Ryukishi07"));
            series.Add(new Serie("Umineko", 3, "Murder Mystery", "Ryukishi07"));
            series.Add(new Serie("Evangelion", 2, "Shounen", "Hideaki Anno"));
            series.Add(new Serie("Lain", 1, "Phylo", "Yoshitoshi Abe"));
            //preguntar al profe si la REDUXeacion debe ser si o si console.writeado
            juegos.Add(new Videojuego("Undertale", 6, "RPG", "Toby Fox"));
            juegos.Add(new Videojuego("Dying Light", 30, "Zombie Parkour RPG", "Techland"));
            juegos.Add(new Videojuego("Yume Nikki", 4, "Puzzle", "kikiyama"));
            juegos.Add(new Videojuego("Lobotomy Corporation", 20, "Management", "Project Moon"));
            juegos.Add(new Videojuego("Watch Dogs", 30, "Open World", "Ubisoft"));

            int cantS = 0;
            int cantV = 0;
            Serie lSerie = new Serie();
            Videojuego lJuego = new Videojuego();
            for (int i = 0; i < series.Count(); i++)
            {
                series[i].Entregar();
                juegos[i].Entregar();
                if (series[i].IsEntregado() == true)
                {
                    cantS++;
                    series[i].Devolver();
                }
                if (i < series.Count() - 1)
                {
                    if (series[i].CompareTo(lSerie) == 1)
                       lSerie = series[i];
                }
                else
                {
                    lSerie.MostrarDetalles();
                }
            }
            for (int i = 0; i < juegos.Count(); i++)
            {
                if (juegos[i].IsEntregado() == true)
                {
                    cantV++;
                    juegos[i].Devolver();
                }
                if (i < juegos.Count() - 1)
                {
                    if (juegos[i].CompareTo(lJuego) == 1)
                    {
                        lJuego = juegos[i];
                    }
                }
                else
                {
                    lJuego.MostrarDetalles();
                }
            }
            Console.ReadKey();
        }
    }
}
