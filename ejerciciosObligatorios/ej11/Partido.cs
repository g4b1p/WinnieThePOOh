using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    internal class Partido
    {
        string[] equipos;
        string[] Equipos { get{ return equipos; } set{ equipos = value; } }

        public Partido(string[] equipos)
        {
            this.equipos = equipos;
        }

        public string Enfrentamiento()
        {
            Random r = new Random();
            return $"{equipos[r.Next(0, equipos.Count())]} vs {equipos[r.Next(0, equipos.Count())]}";
        }
        public string ResultadoPartido()
        {
            Random r = new Random();
            return $"{r.Next(0,6)}-{r.Next(0,6)}";
        }
    }
}
