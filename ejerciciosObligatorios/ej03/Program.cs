using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de contraseñas:");
            int tamaño = int.Parse(Console.ReadLine());
            Password[] passwords = new Password[tamaño];
            bool[] sonFuertes = new bool[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine("Opcion 1: longitud por defecto | Opcion 2: ingresar longitud");
                int caso = int.Parse(Console.ReadLine());
                switch(caso)
                {
                    case 1:
                        passwords[i] = new Password();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese longitud:");
                        passwords[i] = new Password(int.Parse(Console.ReadLine()));
                        break;
                }
                passwords[i].GenerarContraseña();
                sonFuertes[i] = passwords[i].EsFuerte();
                if (sonFuertes[i] == true)
                    Console.WriteLine($"Contraseña generada: {passwords[i].Contraseña} es fuerte");
                else
                    Console.WriteLine($"Contraseña generada: {passwords[i].Contraseña} es debil");
            }

            Console.ReadKey();
        }
    }
}
