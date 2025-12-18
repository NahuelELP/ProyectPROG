using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_12_Propiedades
{
    internal class Propiedades
    {
        private double nota;
        public double Nota //PROPIEDADES con la cuales podemos adentro del get o set hacer validaciones o codigo
        {
            get 
            {
                return this.nota;
            }
            set 
            {
                this.nota = value;
            }
        }
        public double NotaFinal { get; set; } // PROPIEDADES AUTOMATICAS
    }
}
