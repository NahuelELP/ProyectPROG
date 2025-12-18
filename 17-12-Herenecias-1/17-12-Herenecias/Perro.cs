using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_12_Herenecias
{
    internal class Perro : Mascota
    {
        private string color;
        public Perro(int patas, bool tienePatas, bool tienePelaje, string color) : base(patas, tienePatas, tienePelaje)
        {
            this.color = color;
        }
        public string InfoPatas()
        {
            return "El perro tiene: " + GetPatas()+ " patas y tiene un color: "+ color;
        }
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra");
        }
    }
}
