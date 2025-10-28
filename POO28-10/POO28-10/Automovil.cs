using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO28_10
{
    internal class Automovil
    {
        Rueda[] ruedas = new Rueda[4];
        DepositoCombusible depositoCombu = new DepositoCombusible();

        public void Arrancar()
        {
            Console.WriteLine("El auto esta andando");
        }
        public void Frenar()
        {
            Console.WriteLine("El auto freno");
        }
    }
}
