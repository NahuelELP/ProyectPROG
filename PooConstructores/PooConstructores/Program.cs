using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooConstructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono telefono1 = new Telefono();
            Telefono telefono2 = new Telefono(258,4,50,48, true);

            Console.WriteLine(telefono1.InfoMemoria());
            Console.WriteLine(telefono2.InfoMemoria());
        }
    }
}
