using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> Personas = new List<Persona>();
            Console.WriteLine("Bienvenido");
            Console.WriteLine("¿Cuántas personas va a ingresar?");
            int cantP = int.Parse(Console.ReadLine());
            Console.WriteLine("Personas a ingresar: " + cantP);
            for (int i = 1; i <= cantP; i++)
            {
                Console.WriteLine("Constructor de la persona " + i + "? 1 (por defecto), 2 (Nombre, Edad, Sexo), 3 (todo)");
                int decision = int.Parse(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                        Console.WriteLine("Constructor predeterminado (vacio) seleccionado.");
                        Personas.Add(new Persona());
                        Personas[i-1].SetNombre("Juan");
                        Personas[i-1].SetEdad(18);
                        Personas[i-1].SetSexo('H');
                        Personas[i-1].SetPeso(60);
                        Personas[i-1].SetAltura(1.70);

                        break;
                    case 2:
                        Console.WriteLine("Constructor basico (Nombre, Edad, Sexo) seleccionado.");
                        Console.WriteLine("Ingrese los valores en el siguiente orden: N, E, S");
                        Personas.Add(new Persona(Console.ReadLine(), int.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())));
                        Personas[i-1].SetPeso(60);
                        Personas[i-1].SetAltura(1.70);
                        break;
                    case 3:
                        Console.WriteLine("Constructor completo (Nombre, Edad, Sexo, Peso, Altura) seleccionado.");
                        Console.WriteLine("Ingrese los valores en el siguiente orden: N, E, S, P, A");
                        Personas.Add(new Persona(Console.ReadLine(), int.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
                        break;
                }
            }

            foreach(Persona p in Personas) {
                Console.WriteLine();
                p.MostrarDetalles();
                p.ComprobarSexo(p.Sexo);
                if (p.EsMayorEdad(p.Edad) == true)
                {
                    Console.WriteLine($"{p.Nombre} Es mayor de edad");
                }
                else
                {
                    Console.WriteLine($"{p.Nombre} No es mayor de edad");
                }
                if (p.CalcularIMC(p.Peso, p.Altura) == -1)
                {
                    Console.WriteLine($"{p.Nombre} Está en el peso ideal");
                }
                else if (p.CalcularIMC(p.Peso, p.Altura) == 1)
                {
                    Console.WriteLine($"{p.Nombre} Está por encima de su peso ideal");
                }
                else
                {
                    Console.WriteLine($"{p.Nombre} Está por debajo de su peso ideal");
                }
            }

            Console.ReadKey();
        }
    }
}
