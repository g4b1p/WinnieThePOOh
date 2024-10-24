using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repartidor repartidor = new Repartidor("Juan", 26, 20000, "Zona 3");
            Repartidor repartidor1 = new Repartidor("Pedro", 16, 4000, "Zona 3");
            Comercial comercial = new Comercial("Maria", 23, 10233, 500);
            Comercial comercial1 = new Comercial("Claudia", 70, 7000, 400);

            repartidor.P_LUS();
            repartidor1.P_LUS();
            comercial.P_LUS();
            comercial1.P_LUS();

            Console.WriteLine($"{repartidor.Salary} | {repartidor1.Salary} | {comercial.Salary} | {comercial1.Salary}");

            Console.ReadKey();
        }
    }
}
