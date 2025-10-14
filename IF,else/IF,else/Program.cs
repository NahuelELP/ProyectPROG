using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame tu tiket, tenes?");
            string Tiket = (Console.ReadLine());
            Console.WriteLine("Y cuantos años tenes?");
            int Edad = int.Parse(Console.ReadLine());

            if (Tiket == "si" && Edad >= 15) //Ambas se tienen que cumplir con -----> || con esto solo se tiene que cumplir uno y ya entra al if
            {
                Console.WriteLine("Ok pasa");
            }
            else
                {
                Console.WriteLine("No podes pasar");
                }
        }
    }
}
