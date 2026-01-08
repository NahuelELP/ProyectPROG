using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    internal class Auto : IVehiculo
    {
        public int Velocidad { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("El auto acelera");
            Velocidad = 10;
        }
        public void Detenerse()
        {
            Console.WriteLine("El auto se detiene");
            Velocidad = 0;
        }
    }
}
