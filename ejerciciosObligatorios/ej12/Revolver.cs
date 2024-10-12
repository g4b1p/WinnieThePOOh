using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Revolver
    {
        int posActual;
        int posBala;

        public int PosActual {get { return posActual; } set{ posActual = value; } }
        public int PosBala { get { return posBala; } set { posBala = value; } }

        public Revolver(int PA, int PB) 
        { 
            posActual = PA;
            posBala = PB;
        }
        public bool Disparar()
        {
            if(posActual == posBala)
                return true;
            else
                return false;
        }
        public void SiguienteBala()
        {
            posActual++;
            if(posActual > 8)
                posActual = 1;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Posicion actual del tambor: {posActual}, Posicion de la bala: {posBala}");
        }
    }
}
