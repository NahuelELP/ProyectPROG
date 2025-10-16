using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entryConfirmation = "";

            do{
                Console.WriteLine("Seguis en el bucle o te vas?");
                entryConfirmation = Console.ReadLine();
            } while (entryConfirmation == "si");
        }
    }
}
//Diferencia de while y do-wihle, el primero va a confirmar si se puede entrar, el segundo entra sin preguntar al codigo