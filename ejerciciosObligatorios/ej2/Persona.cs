using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ej02
{
    internal class Persona
    {
        string nombre = "";
        int edad = 0;
        char sexo = 'H';
        string dni;
        double peso = 0;
        double altura = 0;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public char Sexo { get { return sexo; } set { sexo = value; } }
        public string DNI { get { return dni; } set { dni = value; } }
        public double Peso { get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }
        
        public Persona()
        {
            GenerarDNI();
        }
        public Persona(string N, int E, char S)
        {
            nombre = N;
            edad = E;
            sexo = S;
            GenerarDNI();
        }
        public Persona(string N, int E, char S, double P, double A)
        {
            nombre = N;
            edad = E;
            sexo = S;
            peso = P;
            altura = A;
            GenerarDNI();
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
            char[] letras = {'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};
            Random r = new Random();
            int dienai = r.Next(00000000, 99999999);
            for (int i = 0; i <= 23; i++)
            {
                if (dienai % 23 == i)
                {
                  DNI = dienai.ToString();
                  DNI += letras[i];
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
