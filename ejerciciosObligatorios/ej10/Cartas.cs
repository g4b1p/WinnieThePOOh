using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ej10
{
    internal class Cartas
    {
        int num;
        string palo;


        public int Num { get { return num; } set { num = value; } }
        public string Palo { get { return palo; } set { palo = value; } }

        public Cartas(int N, string P)
        {
            num = N;
            palo = P;
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
        public void MostrarDetalles()
        {
            Console.WriteLine($"{num} {palo}");
        }
    }
}