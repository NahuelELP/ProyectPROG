using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de termometro");
            double Temperatura = double.Parse(Console.ReadLine());

            if (Temperatura <= 35)
            {
                Console.WriteLine("hipotermia");

            }
            else
            {
                if(Temperatura >=36 && Temperatura <= 37.5)
                {
                    Console.WriteLine("Temp normal");
                }
                else
                {
                    if(Temperatura >=37.6 && Temperatura <=40)
                    {
                        Console.WriteLine("Fiebre");
                    }
                    else
                    {
                        Console.WriteLine("Temperatura muy alta");
                    }
                }
            }
            
        }
    }
}
//Ambas se tienen que cumplir con -----> || con esto solo se tiene que cumplir uno y ya entra al if