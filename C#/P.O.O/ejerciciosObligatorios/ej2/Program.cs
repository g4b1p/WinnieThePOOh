using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> Personas = new List<Persona>();
            Persona p1 = new Persona();
            Persona p2 = new Persona("Juan Carlos IV", 45, 'H');
            Persona p3 = new Persona("Maria Laura", 21, 'M', "48919226W", 64, 1.72);
            Personas.Add(p1);
            Personas.Add(p2);
            Personas.Add(p3);

            Console.WriteLine("Ingrese los datos correspondientes en el siguiente orden: Nombre, Edad, Sexo, Peso, Altura");
            p1.SetNombre(Console.ReadLine());
            p1.SetEdad(int.Parse(Console.ReadLine()));
            p1.SetSexo(char.Parse(Console.ReadLine()));
            p1.GenerarDNI();
            p1.SetPeso(double.Parse(Console.ReadLine()));
            p1.SetAltura(double.Parse(Console.ReadLine()));

            Console.WriteLine("Ingrese los datos correspondientes en el siguiente orden: Peso, Altura");
            p2.GenerarDNI();
            p2.SetPeso(double.Parse(Console.ReadLine()));
            p2.SetAltura(double.Parse(Console.ReadLine()));

            foreach(Persona p in Personas) {
                if (p.CalcularIMC(p.Peso, p.Altura) == -1)
                {
                    Console.WriteLine($"{p.Nombre} Está en el peso ideal");
                }
                else if (p.CalcularIMC(p.Peso, p.Altura) == 1)
                {
                    Console.WriteLine($"{p.Nombre} Tiene sobrepeso");
                }
                else
                {
                    Console.WriteLine($"{p.Nombre} Tiene flacura");
                }
                if (p.EsMayorEdad(p.Edad) == true)
                {
                    Console.WriteLine($"{p.Nombre} Es mayor de edad");
                }
                else
                {
                    Console.WriteLine($"{p.Nombre} No es mayor de edad");
                }
                p.ComprobarSexo(p.Sexo);
            }

            p1.MostrarDetalles();
            p2.MostrarDetalles();
            p3.MostrarDetalles();

            Console.ReadKey();
        }
    }
}
