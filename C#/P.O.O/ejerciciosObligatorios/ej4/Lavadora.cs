using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
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

        public override void PrecioFinal()
        {
            base.PrecioFinal();
            if (Carga > 30)
            {
                PrecioBase += 50;
            }
        }
        double GetCarga()
        {
            return Carga;
        }
    }
}
