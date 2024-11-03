using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej15
{
    internal class AguaMineral : Bebida
    {
        string originPlace;
        public string OriginPlace { get { return originPlace; } set { originPlace = value; } }

        public AguaMineral(int id, float quantityOfLiters, float price, string brand, string originPlace) : base(id, quantityOfLiters, price, brand)
        {
            this.originPlace = originPlace;
        }
    }
}
