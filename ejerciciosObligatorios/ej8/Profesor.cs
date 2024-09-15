using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    internal class Profesor : Instituto
    {
        string materia;
        public string Materia { get { return materia; } set { materia = value; } }

        public Profesor(string M, string N, int E, char S) : base (N, E, S)
        {
            Materia = M;
        }
    }
}
