using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbitoVariables
{
    internal class Program
    {
        static int numero1;
        static void Main(string[] args)
        {
            Console.WriteLine(Prueba());
        }
        public static int Prueba()
        {
            numero1 = 2;
            int resultado = numero1 + 1;
            return resultado;
        }
    }
}
