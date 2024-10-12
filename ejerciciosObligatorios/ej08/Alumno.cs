using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    internal class Alumno : Instituto, IAsistencia
    {
        int calificAtual;
        public int CalificActual { get { return calificAtual; } set { calificAtual = value; } }
        public bool Asistencia()
        {
            Random r = new Random();
            int fue = r.Next(0,101);
            if(fue < 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Alumno(int C ,string N, int E, char S) : base(N, E, S)
        {
            calificAtual = C;
            Asistencia();
        }
        public bool Aprobado()
        {
            if (CalificActual < 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
