using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej5
{
    internal interface IEntregable
    {
        void Entregar();
        void Devolver();
        bool IsEntregado();
        void CompareTo(Object a);
    }
}
