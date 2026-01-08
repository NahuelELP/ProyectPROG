using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    internal class Bicicleta : IVehiculo
    {
        public int Velocidad { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("La vicicleta acelera");
            Velocidad = 5;
        }
        public void Detenerse()
        {
            Console.WriteLine("La bicicleta se detiene");
            Velocidad = 0;
        }
    }
}
