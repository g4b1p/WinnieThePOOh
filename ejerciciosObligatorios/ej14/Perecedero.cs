using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej14
{
    internal class Perecedero : Producto
    {
        int useByDate;
        public int UseByDate { get { return useByDate; } set { useByDate = value; } }

        public Perecedero(string name, float price, int useByDate) : base(name, price)
        {
            this.useByDate = useByDate;
        }

        public override float Calcular(List<Producto> a)
        {
            float precio = base.Calcular(a);
            if (useByDate == 3)
                return precio / 2;
            else if (useByDate == 2)
                return precio / 3;
            else if (useByDate == 1)
                return precio / 4;
            return precio;
        }
        public override void MostrarDetalles()
        {
            Console.WriteLine("----");
            base.MostrarDetalles();
            Console.WriteLine("UseBy: " + useByDate + "dias");
            Console.WriteLine("----");
        }
    }
}
