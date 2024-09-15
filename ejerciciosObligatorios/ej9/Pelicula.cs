using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej09
{
    internal class Pelicula
    {
        string titulo;
        public string Titulo { get { return titulo; } set { titulo = value; } }
        int duracion;
        public int Duracion { get { return duracion; } set { duracion = value; } }
        int edadMinima;
        public int EdadMinima { get { return edadMinima; } set { edadMinima = value; } }
        string director;
        public string Director { get { return director; } set { director = value; } }
        double precio;
        public double Precio { get { return precio; } set { precio = value; } }
        public Pelicula(string titulo, int duracion, int edadMinima, string director, double precio)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima = edadMinima;
            this.director = director;
            this.precio = precio;
        }
    }
}