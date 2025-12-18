using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class ClaseHija : ClasePadre
    {
        public override void MostrarMensaje()
        {
            Console.WriteLine("Mensaje desde la clase hija");
        }
    }
}
