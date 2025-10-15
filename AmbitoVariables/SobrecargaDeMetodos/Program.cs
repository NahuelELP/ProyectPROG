using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sobrecarga de metodos, mismo nombre en el metodo, mas o menos parametros
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(14));
            Console.WriteLine(rnd.Next(14, 16));
            Console.WriteLine(rnd.Next());

            Console.WriteLine(Suma(10,15));
            Console.WriteLine(Suma(1,2,3));
        }
        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Suma(int num1, int num2,int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
