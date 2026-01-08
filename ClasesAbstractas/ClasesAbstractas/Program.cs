using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            Bicicleta bici = new Bicicleta();

            auto.Acelerar();
            auto.Detenerse();
            bici.Acelerar();
            bici.Detenerse();
        }
    }
}
