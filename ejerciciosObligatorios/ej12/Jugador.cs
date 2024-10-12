using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Jugador
    {
        int id;
        string nombre = "Jugador";
        bool vivo = true;
        public int ID { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre= value; } }
        public bool Vivo { get { return vivo; } set { vivo = value; } }

        public Jugador(int ID) 
        { 
            id = ID;
        }

        public void Disparar(Revolver r)
        {
            if(r.PosBala == r.PosActual) 
            {
                vivo = false;
            }
        }
    }
}
