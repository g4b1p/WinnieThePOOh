using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej15
{
    internal class Bebida
    {
        int id;
        float quantityOfLiters;
        float price;
        string brand;
        public int ID { get { return id; } set { id = value; } }
        public float QuantityOfLiters { get { return quantityOfLiters; } set { quantityOfLiters = value; } }
        public float Price { get { return price; } set { price = value; } }
        public string Brand { get { return brand; } set { brand = value; } }

        public Bebida(int id, float quantityOfLiters, float price, string brand) 
        {
            this.id = id;
            this.quantityOfLiters = quantityOfLiters;
            this.price = price;
            this.brand = brand;
        }
    }
}
