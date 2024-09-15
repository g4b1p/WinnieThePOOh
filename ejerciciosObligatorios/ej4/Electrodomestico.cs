using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    internal class Electrodomestico
    {
        double precioBase = 100;
        string color = "Blanco";
        char consumoEnergetico = 'F';
        double peso = 5;

        public double PrecioBase { get { return precioBase; } set { precioBase = value; } }
        public string Color { get { return color; } set { color = value; } }
        public char  ConsumoEnergetico { get { return consumoEnergetico; } set { consumoEnergetico = value; } }
        public double Peso { get { return peso; } set { peso = value; } }

        public Electrodomestico()
        {
        }
        public Electrodomestico(double Pr, double Pe)
        {
            PrecioBase = Pr;
            Peso = Pe;
        }
        public Electrodomestico(double Pr, string Col, char Con, double Pe)
        {
            PrecioBase = Pr;
            Color = Col.ToLower();
            ConsumoEnergetico = Con;
            Peso = Pe;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine(PrecioBase);
            Console.WriteLine(Color);
            Console.WriteLine(ConsumoEnergetico);
            Console.WriteLine(Peso);
        }
        public void ComprobarConsumoEnergetico(char letra)
        {
            if (letra <= 65 && letra >=70)
            {
                ConsumoEnergetico = 'F';
            }
        }
        public void ComprobarColor(string color)
        {
            bool es = false;
            string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };
            foreach(string cs in colores)
            {
                if(cs == color)
                {
                    es = true;
                }
            }
            if (es == false)
            {
                Color = "Blanco";
            }
        }
        public virtual double PrecioFinal()
        {
            if(ConsumoEnergetico == 'A' )
            {
                if(Peso >=0 && Peso <= 19)
                {
                    return PrecioBase + 110;
                }
                else if (Peso >= 20 && Peso <=49)
                {
                    return PrecioBase + 150;
                }
                else if(Peso >= 50 && Peso <= 79)
                {
                    return PrecioBase + 180;
                }
                else
                {
                    return PrecioBase + 200;
                }
            }
            else if (ConsumoEnergetico == 'B')
            {
                if (Peso >= 0 && Peso <= 19)
                {
                    return PrecioBase + 90;
                }
                else if (Peso >= 20 && Peso <= 49)
                {
                    return PrecioBase + 130;
                }
                else if (Peso >= 50 && Peso <= 79)
                {
                    return PrecioBase + 160;
                }
                else
                {
                    return PrecioBase + 180;
                }
            }
            else if (ConsumoEnergetico == 'C')
            {
                if (Peso >= 0 && Peso <= 19)
                {
                    return PrecioBase + 70;
                }
                else if (Peso >= 20 && Peso <= 49)
                {
                    return PrecioBase + 110;
                }
                else if (Peso >= 50 && Peso <= 79)
                {
                    return PrecioBase + 140;
                }
                else
                {
                    return PrecioBase + 160;
                }
            }
            else if (ConsumoEnergetico == 'D')
            {
                if (Peso >= 0 && Peso <= 19)
                {
                    return PrecioBase + 60;
                }
                else if (Peso >= 20 && Peso <= 49)
                {
                    return PrecioBase + 100;
                }
                else if (Peso >= 50 && Peso <= 79)
                {
                    return PrecioBase + 130;
                }
                else
                {
                    return PrecioBase + 150;
                }
            }
            else if (ConsumoEnergetico == 'E')
            {
                if (Peso >= 0 && Peso <= 19)
                {
                    return PrecioBase + 40;
                }
                else if (Peso >= 20 && Peso <= 49)
                {
                    return PrecioBase + 80;
                }
                else if (Peso >= 50 && Peso <= 79)
                {
                    return PrecioBase + 110;
                }
                else
                {
                    return PrecioBase + 130;
                }
            }
            else
            {
                if (Peso >= 0 && Peso <= 19)
                {
                    return PrecioBase + 20;
                }
                else if (Peso >= 20 && Peso <= 49)
                {
                    return PrecioBase + 60;
                }
                else if (Peso >= 50 && Peso <= 79)
                {
                    return PrecioBase + 90;
                }
                else
                {
                    return PrecioBase + 110;
                }
            }
        }
        double GetPrecioBase()
        {
            return PrecioBase;
        }
        string GetColor()
        {
            return Color;
        }
        char GetConsumoEnergetico()
        {
            return ConsumoEnergetico;
        }
        double GetPeso()
        {
            return Peso;
        }
    }
}
