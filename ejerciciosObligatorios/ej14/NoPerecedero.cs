using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ej14
{
    internal class NoPerecedero : Producto
    {
        string type;
        public string Type { get { return type; } set { type = value; } }

        public NoPerecedero(string name, float price, string type) : base(name, price)
        {
            this.type = type;
        }

        public override float Calcular(List<Producto> a) 
        {
            return base.Calcular(a);
        }
        public override void MostrarDetalles()
        {
            Console.WriteLine("----");
            base.MostrarDetalles();
            Console.WriteLine("Type: " + type);
            Console.WriteLine("----");
        }
    }
}
