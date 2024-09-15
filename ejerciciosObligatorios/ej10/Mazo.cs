using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    internal class Mazo
    {
        List<Cartas> cartas;

        public List<Cartas> Cartas { get { return cartas; } set { cartas = value; } }

        public Mazo(List<Cartas> C) 
        { 
            cartas = C;
        }

        public void Barajar(List<Cartas> a)
        {
            Random r = new Random();
            for (int i = 0; i < a.Count(); i++)
            {
                int aux = r.Next(0, a.Count());
                Cartas aux2;
                aux2 = a[i];
                a[i] = a[aux];
                a[aux] = aux2;
            }
        }

        public Cartas siguienteCarta(List<Cartas> a)
        {
            for (int i = 0; i < 1; i++)
            {
                return a[i];
            }
            return a.FirstOrDefault();
        }
        public void MostrarDetalles(List<Cartas> a)
        {
            for (int i = 0; i < a.Count(); i++)
            {
                Console.WriteLine($"{a[i].Num} {a[i].Palo}");
            }
        }
    }
}
