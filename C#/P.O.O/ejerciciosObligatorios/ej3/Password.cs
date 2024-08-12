using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ej3
{
    internal class Password
    {
        int longitud = 8;
        string contraseña;

        public int Longitud { get { return longitud; } set { longitud = value; } }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }

        public Password(string C)
        {
            this.contraseña = C;
        }
        public Password(int L)
        {
            this.longitud = L;
        }

        public bool EsFuerte()
        {
            int mayus = 0;
            int mins = 0;
            int nums = 0;

            for(int i = 0; i < contraseña.Length; i++)
            {
                if (contraseña[i] >=97 && contraseña[i] <= 122)
                {
                    mins++;
                }
                else if (contraseña[i] >=65 && contraseña[i] <= 90)
                {
                    mayus++;
                }
                else
                {
                    nums++;
                }
            }
            if(mayus > 2 && mins > 1 && nums > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void GenerarContraseña()
        {

        }
    }
}
