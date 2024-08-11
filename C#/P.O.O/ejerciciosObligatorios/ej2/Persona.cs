using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2
{
    internal class Persona
    {
        string sexo;
        string nombre;
        int edad;
        int dni;
        double peso;
        double altura;

        public string Sexo { get { return sexo; } set { sexo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public int DNI { get { return dni; } set { dni = value; } }
        public double Peso { get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }
        
        public Persona()
        {

        }
        public Persona(string N, int E, string S)
        {
            this.Nombre = N;
            this.Edad = E;
            this.Sexo = S;
        }
        public Persona(string N, int E, string S, int D, double P, double A)
        {
            this.Nombre = N;
            this.Edad = E;
            this.Sexo = S;
            this.DNI = D;
            this.Peso = P;
            this.Altura = A;
        }

        public int CalcularIMC(double pes, double alt)
        {
            double IMC = pes / (alt*alt);
            if (IMC < 20)
            {
                return -1;
            }
            else if (IMC >= 20 && IMC <= 25)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }   
        public bool EsMayorEdad(int ed)
        {
            if (ed >= 18)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public void ComprobarSexo(string sex)
        {
            if (sex == Sexo)
            {

            }
        }
    }
}
