using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _17_12_Herenecias
{
    internal class Hamster : Mascota
    {
        private double peso;
        private string color;
        public Hamster(int patas, bool tienePatas, bool tienePelaje, string color, double peso) : base(patas, tienePatas, tienePelaje)
        {
            this.color = color;
            this.peso = peso;
        }
        public override void HacerSonido()
        {
            Console.WriteLine("El hamster gruñe");
        }
    }
}
