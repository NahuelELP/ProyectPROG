using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichUwu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En que estacion del año estamos?");
            string EstacAño = Console.ReadLine();
            switch (EstacAño)
            { 
                case "Verano":
                    Console.WriteLine("calor");
                    break;
                case "Invierno":
                    Console.WriteLine("frio");
                    break;
                case "Otoño":
                    Console.WriteLine("Masomenos");
                    break;
                case "Primavera":
                    Console.WriteLine("Masomenos2.0");
                    break;
                default: Console.WriteLine("No coincide con una estacion del año ---->" + EstacAño);
                    break;
            }
        }
    }
}
//char = '+'; <----simbolizacion de signos o letras unicas. 