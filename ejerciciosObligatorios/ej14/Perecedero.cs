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
            base.Calcular(a);
            foreach (Producto i in a)
            {
                if (useByDate == 3)
                    return Price /= 2;
                else if (useByDate == 2)
                    return Price /= 3;
                else if (useByDate == 1)
                    return Price /= 4;
            }
            return Price;
        }
    }
}
