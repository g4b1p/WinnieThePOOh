using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej8
{
    internal class Aula
    {
        string nombre;
        int edad;
        char sexo;

        public string Nombre {  get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public char Sexo { get { return sexo; } set { sexo = value; } }

        public Aula(string N, int E, char S)
        {
            Nombre = N;
            Edad = E;
            Sexo = S;
        }
    }
}
