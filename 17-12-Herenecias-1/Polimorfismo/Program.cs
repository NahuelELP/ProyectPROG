using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClasePadre clasePadre = new ClasePadre();
            ClaseHija claseHija = new ClaseHija();

            ClasePadre obj = new ClaseHija();

            claseHija.MostrarMensaje();
            clasePadre.MostrarMensaje();
            obj.MostrarMensaje();
        }
    }
}
