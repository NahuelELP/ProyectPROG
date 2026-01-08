using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    internal interface IVehiculo
    {
        void Acelerar();
        void Detenerse();
        int Velocidad { get; set; }
    }
}
