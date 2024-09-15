using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej06
{
    internal class Libro
    {
        
        long isbn = 00000000000000;
        string titulo = "";
        string autor = "";
        int numPaginas = 100;

        public long ISBN { get { return isbn; } set { isbn = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Autor { get { return autor; } set { autor = value; } }
        public int NumPaginas { get { return numPaginas; } set { numPaginas = value; } }

        public Libro () 
        { 
        
        }
        public Libro (long I, string T, string A, int N)
        {
            ISBN = I;
            Titulo = T;
            Autor = A;
            NumPaginas = N;
        }

        public void SetISBN(long I)
        {
            ISBN = I;
        }
        public void SetTitulo(string T)
        {
            Titulo = T;
        }
        public void SetAutor(string A)
        {
            Autor = A;
        }
        public void SetNumPaginas(int P)
        {
            NumPaginas = P;
        }
        public long GetISBN()
        {
            return ISBN;
        }
        public string GetTitulo()
        {
            return Titulo;
        }
        public string GetAutor()
        {
            return Autor;
        }
        public int GetNumPaginas()
        {
            return NumPaginas;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"El libro {Titulo} con el N° de ISBN: {ISBN} creado por el autor {Autor} tiene {NumPaginas} paginas");
        }
    }
}
