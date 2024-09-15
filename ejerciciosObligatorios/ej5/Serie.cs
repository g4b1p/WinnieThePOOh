using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    internal class Serie : IEntregable
    { 
        string titulo = "";
        int numTemps = 3;
        bool entregado = false;
        string genero = "";
        string creador = "";
        
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int NumTemps { get {return numTemps;} set {numTemps = value;} }
        public bool Entregado { get {return entregado;} set {entregado = value;} }
        public string Genero {  get {return genero;} set {genero = value;} }
        public string Creador { get { return creador; } set { creador = value; } }

        public Serie()
        {

        }
        public Serie(string T, string C)
        {
            titulo = T;
            creador = C;
        }
        public Serie(string T, int N, string G, string C)
        {
            titulo = T;
            numTemps = N;
            genero = G;
            creador = C;
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
        //casting (ME CAGO EN EL PUTO CASTING DE LOS COJONES)
            Serie serie = a as Serie;
            if (numTemps > serie.numTemps)
                estado = 1;
            else if (numTemps == serie.numTemps)
                estado = 0;

            return estado;
        }
        public void SetTitulo(string T)
        {
            titulo = T;
        }
        public void SetNumTemps(int N)
        {
            numTemps = N;
        }
        public void SetGenero(string G)
        {
            genero = G;
        }
        public void SetCreador(string C)
        {
            creador = C;
        }
        public string GetTitulo()
        {
            return titulo;
        }
        public int GetNumTemps()
        {
            return numTemps;
        }
        public string GetGenero()
        {
            return genero;
        }
        public string GetCreador()
        {
            return creador;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine("Detalles de la Serie:");
            Console.WriteLine("\tTitulo: " + titulo);
            Console.WriteLine("\tNumero de temporadas: " + numTemps);
            Console.WriteLine("\tGenero: " + genero);
            Console.WriteLine("\tCreador: " + creador);
        }
    }
}
