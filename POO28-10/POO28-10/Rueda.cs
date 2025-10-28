using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO28_10
{
    internal class Rueda
    {
        private double peso;
        private string tamaño;
        private string tipo;
        private string material;

        public void AsignarPeso(double p)
        {
            peso = p;
        }
        public void Desplazar()
        {
            Console.WriteLine("El neumatico desplaza el automovil");

        }
    }
}
