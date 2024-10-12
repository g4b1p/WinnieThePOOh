using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej12
{
    internal class Juego
    {
        List<Jugador> jugadores;
        Revolver revolver;

        public List<Jugador> Jugadores { get { return jugadores; } set { jugadores = value; } }
        public Revolver Revolver { get { return revolver; } set { revolver = value; } }

        public Juego(List<Jugador> J, Revolver R)
        {
            jugadores = J;
            revolver = R;
        }

        public bool FinJuego()
        {
            foreach (Jugador j in jugadores)
            {
                if (j.Vivo == false)
                    return true;
            }
            return false;
        }
        public void Ronda()
        { 
            while(FinJuego() == false) 
            {
                foreach (Jugador j in jugadores)
                {
                    j.Disparar(revolver);
                    revolver.Disparar();
                    revolver.MostrarDetalles();
                    if (revolver.Disparar() == true)
                    {
                        Console.WriteLine($"El {j.Nombre} {j.ID} se ha disparado y ha muerto");
                    }
                    else
                        Console.WriteLine($"El {j.Nombre} {j.ID} se ha disparado y sigue vivo");
                    if (FinJuego() == true)
                        break;
                    else
                        revolver.SiguienteBala();
                }
            }
        }
    }
}
