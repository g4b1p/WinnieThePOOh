using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej5
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
            Titulo = T;
            HorasEstimadas = H;

        }
        public Videojuego(string T, int H, string G, string C)
        {
            Titulo = T;
            HorasEstimadas = H;
            Genero = G;
            Compañia = C;
        }

        public void Entregar()
        {
            Entregado = true;
        }
        public void Devolver()
        {
            Entregado = false;
        }
        public bool IsEntregado()
        {
            return Entregado;
        }
        /*public void CompareTo(Object a)
        {
            horasEstimadas = int.Parse(string.Format("{0}", a));
        } Help, portero lo sacó de star overflow */
        public void SetTitulo(string T)
        {
            Titulo = T;
        }
        public void SetHorasEstimadas(int H)
        {
            HorasEstimadas = H;
        }
        public void SetGenero(string G)
        {
            Genero = G;
        }
        public void SetCompañia(string C)
        {
            Compañia = C;
        }
        public string GetTitulo()
        {
            return Titulo;
        }
        public int GetHorasEstimadas()
        {
            return HorasEstimadas;
        }
        public string GetGenero()
        {
            return Genero;
        }
        public string GetCompañia()
        {
            return Compañia;
        }
    }
}
