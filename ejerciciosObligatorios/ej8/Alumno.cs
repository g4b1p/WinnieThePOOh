using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej8
{
    internal class Alumno : Instituto
    {
        int calificAtual;
        public int CalificActual { get { return calificAtual; } set { calificAtual = value; } }
        public Alumno(int C ,string N, int E, char S) : base(N, E, S)
        {
            calificAtual = C;
        }
    }
}
