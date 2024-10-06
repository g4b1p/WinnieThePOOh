using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej09
{
    internal class Cine
    {
        int filas;
        int columnas;
        List<Asiento> asientos;
        Pelicula peliculaActual;

        public int Filas { get { return filas; } set { filas = value; } }
        public int Columnas { get { return columnas; } set { columnas = value; } }
        public List<Asiento> Asientos { get { return asientos; } set { asientos = value; } }
        public Pelicula PeliculaActual { get { return peliculaActual; } set { peliculaActual = value; } }

        public Cine(int filas, int columnas, Pelicula peliculaActual)
        {
            this.filas = filas;
            this.columnas = columnas;
            this.peliculaActual = peliculaActual;
        }
    }
}