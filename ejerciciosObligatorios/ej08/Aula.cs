using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    internal class Aula
    {
        int idau;
        int estmax;
        string matdest;
        Profesor profe;
        List<Alumno> alumnos;

        public int IDau { get { return idau; } set { idau = value; } }
        public int Estmax { get { return estmax; } set { estmax = value; } }
        public string Matdest { get { return matdest; } set { matdest = value; } }

        public bool AptoClase()
        {
            if (profe.Asistencia() == true)
            {
                if (profe.Materia == matdest)
                {
                    int alumnosast = 0;
                    foreach (Alumno a in alumnos)
                    {
                        if (a.Asistencia() == true) {  alumnosast++; }
                    }
                    if (alumnosast > alumnos.Count / 2)
                    {
                        return true;
                    }
                    else 
                    { 
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public Aula(int i, int e, string m, Profesor p, List<Alumno> a)
        {
            this.idau = i;
            this.estmax = e;
            this.matdest = m;
            this.profe = p;
            this.alumnos = a;
        }
    }
}
