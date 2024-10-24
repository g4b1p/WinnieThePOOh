using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej13
{
    internal class Repartidor : Empleado
    {
        string zone;
        public string Zone { get { return zone; } set { zone = value; } }
        
        public Repartidor(string name, int age, int salary, string zone) : base(name, age, salary)
        {
            this.zone = zone;
        }

        public void P_LUS()
        {
            if (Age < 25 && "zona 3" == zone.ToLower())
                Salary += PLUS;
        }
    }
}
