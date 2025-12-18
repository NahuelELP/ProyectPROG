using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_12_Herenecias
{
    internal class Mascota
    {
        private int patas; //Solo si es necesario, Mejor usar privated
        private bool tienePatas;
        private bool tienePelaje;

        public Mascota(int patas, bool tienePatas, bool tienePelaje)
        { // Al crear el constructor en la clase que se hereda a todas las clases, es obligatorio 
          // hacer que se herede ese constructor en cada uno de las clases 
          // que heredaron la clase principal
            this.patas = patas;
            this.tienePatas = tienePatas;
            this.tienePelaje = tienePelaje;
        }
        public int GetPatas()
        {
            return this.patas;
        }
        public void Entretener()
        {
            Console.WriteLine("Esta mascota me entretiene");
        }
        public void DanAmor()
        {
            Console.WriteLine("Esta mascota me da mucho amor");
        }
    }
}
