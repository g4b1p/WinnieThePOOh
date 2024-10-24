using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej13
{
    internal class Comercial : Empleado
    {
        double comission;
        public double Comission { get { return comission; } set { comission= value; } }

        public Comercial(string name, int age, int salary, double comission) : base(name, age, salary)
        {
            this.comission = comission;
        }

        public void P_LUS()
        {
            if (Age > 30 && comission > 200)
                Salary += PLUS;
        }
    }
}
