using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mago Malza = new Mago(23,"Malzahar","mago","hombre");
            Malza.Atacar();
            Malza.Defensa();

        }
    }
}
