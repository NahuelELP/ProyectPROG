using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Operacion(1,5));
        }
        public static int Operacion(int a, int b)
        {
            int numero1 = a + b;
            return numero1;
        }
    }
}
