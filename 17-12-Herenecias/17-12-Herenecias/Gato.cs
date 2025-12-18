using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_12_Herenecias
{
    internal class Gato : Mascota
    {
        private string color;
        private string Pelaje;
        public Gato(int patas, bool tienePatas, bool tienePelaje, string color, string Pelaje) : base(patas, tienePatas, tienePelaje)
        {
            this.color = color;
            this.Pelaje = Pelaje;
        }
        public void Maullar()
        {
            Console.WriteLine("El gato maulla");
        }
    }
}
