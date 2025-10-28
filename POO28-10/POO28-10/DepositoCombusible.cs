using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO28_10
{
    internal class DepositoCombusible
    {
        Rueda rueda1 = new Rueda();
        public double capacidad;
        public double tamaño;
        
        public void ObteniendoPeso()
        {
            rueda1.AsignarPeso(10.5);
        }

        public void AlmacenarCombustible()
        {
            Console.WriteLine("Almacenamiento de combustible del automvil");
        }

    }
}
