using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    internal class Videojuego : IEntregable
    {
        string titulo = "";
        int horasEstimadas = 10;
        bool entregado = false;
        string genero = "";
        string compañia = "";

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int HorasEstimadas { get { return horasEstimadas; } set { horasEstimadas = value; } }
        public bool Entregado { get { return entregado; } set { entregado = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public string Compañia { get { return compañia; } set { compañia = value; } }
        
        public Videojuego()
        {

        }
        public Videojuego(string T, int H)
        {
            titulo = T;
            horasEstimadas = H;

        }
        public Videojuego(string T, int H, string G, string C)
        {
            titulo = T;
            horasEstimadas = H;
            genero = G;
            compañia = C;
        }

        public void Entregar()
        {
            entregado = true;
        }
        public void Devolver()
        {
            entregado = false;
        }
        public bool IsEntregado()
        {
            return entregado;
        }
        public int CompareTo(Object a)
        {
            int estado = -1;
            //casting
            Videojuego videojuego = a as Videojuego;
            if (horasEstimadas > videojuego.horasEstimadas)
                estado = 1;
            else if (horasEstimadas == videojuego.horasEstimadas)
                estado = 0;

            return estado;
        }
        public void SetTitulo(string T)
        {
            titulo = T;
        }
        public void SetHorasEstimadas(int H)
        {
            horasEstimadas = H;
        }
        public void SetGenero(string G)
        {
            genero = G;
        }
        public void SetCompañia(string C)
        {
            compañia = C;
        }
        public string GetTitulo()
        {
            return titulo;
        }
        public int GetHorasEstimadas()
        {
            return horasEstimadas;
        }
        public string GetGenero()
        {
            return genero;
        }
        public string GetCompañia()
        {
            return compañia;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine("Detalles del juego:");
            Console.WriteLine("\tTitulo: " + titulo);
            Console.WriteLine("\tHoras Estimadas: " + horasEstimadas);
            Console.WriteLine("\tGenero: " + genero);
            Console.WriteLine("\tCreador: " + compañia);
        }
    }
}
