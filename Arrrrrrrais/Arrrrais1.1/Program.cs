using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrrrais1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int savedNumbers = 0;
            int[] five = five = new int[5];
            Console.WriteLine("Rellena el array con numeros hasta que pare:");
            for (int i = 0; i < five.Length; i++  ) 
            {
                savedNumbers = int.Parse(Console.ReadLine());
                five[i] = savedNumbers;
            }
            Console.WriteLine("Los numeros guardados son:");
            for (int i= 0; i < five.Length;i++)
            {
                Console.WriteLine(five[i]);
            }
        }
    }
}
