using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej13
{
    abstract class Empleado
    {
        string name;
        int age;
        int salary;
        const int plus = 300;
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Salary { get { return salary; } set { salary = value; } }
        public int PLUS {get {return plus;} }

        public Empleado(string name, int age, int salary) 
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
    }
}
