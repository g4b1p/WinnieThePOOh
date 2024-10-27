using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ej14
{
    internal class Producto
    {
        string name;
        float price;
        public string Name { get { return name; } set { name = value; } }
        public float Price { get { return price; } set { price = value; } }

        public Producto (string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual float Calcular(List<Producto> a)
        {
            return price * a.Count;
        }
        public virtual void MostrarDetalles() 
        {
                Console.WriteLine("Nombre: " + Name);
                Console.WriteLine("Precio: " + Price);

        }
    }
}
