using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profesor profe1 = new Profesor("lite", "Beatrice", 23, 'F');
            Profesor profe2 = new Profesor("mate", "Baldi", 40, 'M');
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Alumno(10, "Bernkastel", 16, 'F'));
            alumnos.Add(new Alumno(6, "Lambdadelta", 13, 'F'));
            alumnos.Add(new Alumno(1, "Battler", 18, 'M'));
            alumnos.Add(new Alumno(5, "Jessica", 17, 'F'));
            alumnos.Add(new Alumno(9, "George", 19, 'M'));
            alumnos.Add(new Alumno(6, "Maria", 10, 'F'));
            List<Aula> aulas = new List<Aula>();
            Aula aulaMate = new Aula(1, 6, "mate", profe2, alumnos);
            Aula aulaLite = new Aula(2, 10, "lite", profe1, alumnos);
            aulas.Add(aulaLite);
            aulas.Add(aulaMate);
            
            foreach (Aula a in aulas) {
                if (a.AptoClase() == true)
                {
                    Console.WriteLine($"Clase dada en aula {a.IDau}");
                    int cantAprobados = 0;
                    int cantAprobadas = 0;
                    foreach (Alumno alumno in alumnos)
                    {
                        if (alumno.Aprobado() == true && alumno.Sexo == 'M')
                        {
                            cantAprobados++;
                        }
                        if (alumno.Aprobado() == true && alumno.Sexo == 'F')
                        {
                            cantAprobadas++;
                        }

                    }
                    Console.WriteLine($"Hay {cantAprobados} alumnos aprobados y {cantAprobadas} alumnas aprobadas.");
                }
            }

            Console.ReadKey();
        }
    }
}
