using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej15
{
    internal class Almacen
    {
        Bebida[][] bebidas = new Bebida[3][];
        public Bebida[][] Bebidas { get { return bebidas; } set { bebidas = value; } }

        public Almacen(Bebida[][] bebidas) 
        {
            this.bebidas = bebidas;
        }

        public float CalculateTotalPrice()
        {
            float totalPrice = 0;
            foreach (var i in bebidas) 
            {
                foreach (var k in i)
                {
                    totalPrice += k.Price;
                }
            }
            return totalPrice;
        }
        public float CalculateTotalBrandPrice()
        {

        }
    }
}
