using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej05
{
    internal interface IEntregable
    {
        void Entregar();
        void Devolver();
        bool IsEntregado();
        int CompareTo(Object a);
    }
}
