using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    internal class Profesor : Instituto, IAsistencia
    {
        string materia;
        public string Materia { get { return materia; } set { materia = value; } }
        public bool Asistencia()
        {
            Random r = new Random();
            int fue = r.Next(0, 101);
            if (fue < 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Profesor(string M, string N, int E, char S) : base (N, E, S)
        {
            Materia = M;
            Asistencia();
        }
    }
}
