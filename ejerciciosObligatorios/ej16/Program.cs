/* 
Partiendo de este codigo, terminar el programa en el que se pueda ver el menu y con las teclas recorrerlo y poder elegir una opcion para hacer algo diferente en cada caso
*/

using System;
using System.Collections.Generic;
using ej16;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menus = new Dictionary<string, string[]>
            {
                { " DDL ", new[] { "Listar contacto", "Buscar contacto", "Agenda llena", "Huecos libres" ,"Salir" } },
                { " DML " , new[] { "Agregar contacto", "Eliminar contacto", "Salir" } },
            };

            var menuPrincipal = new MenuPrincipal(menus);
            List<Contacto> contactos = new List<Contacto>();
            Agenda agenda = new Agenda(contactos, 10);


            foreach (var subMenu in menus)
            {
                foreach (var opcion in subMenu.Value)
                {
                    if (opcion == "Salir")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine("Saliendo del programa...");
                            Environment.Exit(0);
                        });
                    }
                    else if (opcion == "Listar contacto")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            agenda.ListarContactos();
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Agregar contacto")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            Console.WriteLine($"¡Ingrese nombre del nuevo contacto!");
                            string nombre = Console.ReadLine();
                            Console.WriteLine($"¡Ingrese número del nuevo contacto!");
                            int telefono = Convert.ToInt32(Console.ReadLine());
                            agenda.AñadirContacto(new Contacto(nombre, telefono));
                            Console.WriteLine($"¡Contacto {nombre} de número {telefono} agregado con éxito!");
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Eliminar contacto")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            Console.WriteLine("¡¿Cuál contacto?!");
                            string nombre = Console.ReadLine();
                            agenda.EliminarContacto(nombre);
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Buscar contacto")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            Console.WriteLine("¿A quién?");
                            string nombre = Console.ReadLine();
                            agenda.BuscarContacto(nombre);
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Agenda llena")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            if (agenda.AgendaLlena()) Console.WriteLine("La agenda está llena");
                            else Console.WriteLine("La agenda -no- está llena");
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Huecos libres")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            Console.WriteLine($"Huecos libres: {agenda.EspacioAgenda()}");
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                }
            }

            var menuNavigator = new MenuNavegacion(menuPrincipal);
            menuNavigator.Iniciar();
        }
    }
}