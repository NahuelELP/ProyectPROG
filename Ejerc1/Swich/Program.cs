using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Swich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realiza una aplicación que le pida al usuario por consola un número del 1
            al 12.En un condicional switch, deberás evaluar cada uno de los casos y
            según el caso correcto, mostrar por consola el mes que corresponda a ese
            número.Por ejemplo, si el usuario introduce un 5, entonces el mensaje que
            debe aparecer por consola es “Mayo”. Colocar también un mensaje en caso
            de que el usuario introduzca un número que no se encuentre entre el 1 y
            12.*/

            Console.WriteLine("Dame un mes del año introducido por numeros entre o igual a 1 y 12");
            int Mes= int.Parse(Console.ReadLine());

            if(Mes >= 1 && Mes <=12)
            {
                switch(Mes)
                {
                    case 1:
                        Console.WriteLine("Enero");
                        break;
                    case 2:
                        Console.WriteLine("Febrero");
                        break;
                    case 3:
                        Console.WriteLine("Marzo");
                        break;
                    case 4:
                        Console.WriteLine("Abril");
                        break;
                    case 5:
                        Console.WriteLine("Mayo");
                        break;
                    case 6:
                        Console.WriteLine("Junio");
                        break;
                    case 7:
                        Console.WriteLine("Julio");
                        break;
                    case 8:
                        Console.WriteLine("Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Sept");
                        break;
                    case 10:
                        Console.WriteLine("Oct");
                        break;
                    case 11:
                        Console.WriteLine("Nov");
                        break;
                    default:
                        Console.WriteLine("Dic");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No es un numero entre o igual a 1 y 12");
            }
        }
    }
}
