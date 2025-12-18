using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class ClasePadre
    {
        public virtual void MostrarMensaje()
        {
            Console.WriteLine("Mensaje desde la clase padre");
        }
    }
}
