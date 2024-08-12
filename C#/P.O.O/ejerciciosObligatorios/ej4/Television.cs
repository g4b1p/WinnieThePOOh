﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    internal class Television : Electrodomesticos
    {
        int resolucion = 20;
        bool sintonizadorTDT = false;

        public int Resolucion { get { return resolucion; } set { resolucion = value; } }
        public bool SintonizadorTDT { get { return sintonizadorTDT; } set { sintonizadorTDT = value; } }

        public Television() : base()
        {

        }
        public Television(double Pr, double Pe) : base(Pr, Pe)
        {

        }
        public Television(int R, bool S, double Pr, string Col, char Con, double Pe) : base(Pr, Col, Con, Pe) 
        {
            Resolucion = R;
            SintonizadorTDT = S;
        }
        public override void PrecioFinal()
        {
            base.PrecioFinal();
            if (Resolucion > 40)
            {
                PrecioBase += (PrecioBase * 30) / 100;
                if(SintonizadorTDT == true)
                {
                    PrecioBase += 50;
                }
            }
        }
        int GetResolucion()
        {
            return Resolucion;
        }
        bool GetSintonizadorTDT()
        {
            return SintonizadorTDT;
        }
    }
}
