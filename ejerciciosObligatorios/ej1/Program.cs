using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de cuentas que desea utilizar");
            int cantCuentas = int.Parse(Console.ReadLine());
            List<Cuenta> cuentas = new List<Cuenta>();
            for (int i = 0; i < cantCuentas; i++)
            {
                Console.WriteLine($"Ingrese los nombres del titular numero {i+1}");
                cuentas.Add(new Cuenta(Console.ReadLine()));
                Console.WriteLine($"Desea Ingresar/Retirar dinero de la cuenta a nombre de {cuentas[i].Titular}? Si: 1 | No: 2");
                int respuesta = int.Parse(Console.ReadLine());
                if(respuesta == 1)
                {
                    Console.WriteLine($"Ingresar: 1 | Retirar: 2");
                    respuesta = int.Parse(Console.ReadLine());
                    switch (respuesta)
                    {
                        case 1:
                            Console.WriteLine("Ingrese la cantidad de dinero a ingresar:");
                            cuentas[i].Ingresar(double.Parse(Console.ReadLine()));
                            Console.WriteLine($"La cantidad de su cuenta ahora es de: {cuentas[i].Cantidad}");
                            break;
                        case 2:
                            Console.WriteLine("Ingrese la cantidad de dinero a retirar:");
                            cuentas[i].Retirar(double.Parse(Console.ReadLine()));
                            Console.WriteLine($"La cantidad de su cuenta ahora es de: {cuentas[i].Cantidad}");
                            break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
