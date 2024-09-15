using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    internal class Lavadora : Electrodomestico
    {
        double carga = 5;
        public double Carga { get { return carga; } set { carga = value; } }

        public Lavadora()
        {
        }
        public Lavadora(double Pr, double Pe) : base(Pr, Pe)
        {
        }
        public Lavadora(double Car, double Pr, string Col, char Con, double Pe) : base(Pr, Col, Con, Pe)
        {
            Carga = Car;
        }

        public override double PrecioFinal()
        {
            base.PrecioFinal();
            if (Carga > 30)
            {
                return PrecioBase + 50;
            }
            else
            {
                return base.PrecioFinal();
            }
        }
        double GetCarga()
        {
            return Carga;
        }
    }
}
