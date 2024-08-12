using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2
{
    internal class Persona
    {
        string nombre;
        int edad;
        char sexo;
        int dni;
        double peso;
        double altura;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public char Sexo { get { return sexo; } set { sexo = value; } }
        public int DNI { get { return dni; } set { dni = value; } }
        public double Peso { get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }
        
        public Persona()
        {

        }
        public Persona(string N, int E, char S)
        {
            Nombre = N;
            Edad = E;
            Sexo = S;
        }
        public Persona(string N, int E, char S, int D, double P, double A)
        {
            Nombre = N;
            Edad = E;
            Sexo = S;
            DNI = D;
            Peso = P;
            Altura = A;
        }

        public int CalcularIMC(double pes, double alt)
        {
            double IMC = pes / (Math.Pow(alt, 2));
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
        public void ComprobarSexo(char sex)
        {
            if (sex != 'H' && sex != 'M')
            {
                Sexo = 'H';
            }
        }
        public void GenerarDNI()
        {
            int pos = 0;
            char[] ldienai = {'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};
            Random r = new Random();
            int dienai = r.Next(00000000,99999999);
            foreach (char a in ldienai)
            {
                if (dienai % 23 == pos)
                {
                    //DNI = dienai.Concat(a);
                }
            }
        }
        public void MostrarDetalles()
        {
            Console.WriteLine(Nombre);
            Console.WriteLine(Edad);
            Console.WriteLine(Sexo);
            Console.WriteLine(DNI);
            Console.WriteLine(Peso);
            Console.WriteLine(Altura);
        }
        public void SetNombre(string N)
        {
            Nombre = N;
        }
        public void SetEdad(int E)
        {
            Edad = E;
        }
        public void SetSexo(char S)
        {
            Sexo = S;
        }
        public void SetPeso(double P)
        {
            Peso = P;
        }
        public void SetAltura(double A)
        {
            Altura = A;
        }
    }
}
