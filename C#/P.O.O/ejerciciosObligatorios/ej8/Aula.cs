using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej8
{
    internal class Aula
    {
        int idau;
        int estmax;
        string matdest;

        public int IDau { get { return idau; } set { idau = value; } }
        public int Estmax { get { return estmax; } set { estmax = value; } }
        public string Matdest { get { return matdest; } set { matdest = value; } }
    }
}
