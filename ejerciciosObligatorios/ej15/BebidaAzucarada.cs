using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej15
{
    internal class BebidaAzucarada : Bebida
    {
        string sugarPercent;
        public string SugarPercent { get { return sugarPercent; } set { sugarPercent = value; } }

        public BebidaAzucarada(int id, float quantityOfLiters, float price, string brand, string sugarPercent) : base(id, quantityOfLiters, price, brand)
        {
            this.sugarPercent = sugarPercent;
        }
    }
}
