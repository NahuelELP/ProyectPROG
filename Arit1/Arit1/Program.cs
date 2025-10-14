using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribi un numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Tu numero es " + numero);

            int numero1 = 10;
            int numero2 = 20;

            numero1 ++;//+= x sumas el numero que quieras
            numero2 --;//-= x restas el numero que quieras
        }
    }
}
