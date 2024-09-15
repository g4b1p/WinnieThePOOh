using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    internal class Password
    {
        int longitud = 8;
        string contraseña;

        public int Longitud { get { return longitud; } set { longitud = value; } }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }

        public Password()
        {
        }
        public Password(int L)
        {
            Longitud = L;
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
            char[] letrasMa = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] letrasMi = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] nums = { '0', '1', '2', '3','4','5','6','7','8', '9' };
            Random r = new Random();
            int siSale;
            char[] formContraseña = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                siSale = r.Next(0, 3);
                if (siSale == 0)
                {
                    formContraseña[i] = letrasMa[r.Next(0, 26)];
                }
                else if(siSale == 1)
                {
                    formContraseña[i] = letrasMi[r.Next(0, 26)];
                }
                if (siSale == 2)
                {
                    formContraseña[i] = nums[r.Next(0, 9)];
                }
            }
            contraseña = string.Concat(formContraseña);
        }
    }
}
