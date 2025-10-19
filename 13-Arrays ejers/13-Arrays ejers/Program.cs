using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Arrays_ejers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraysNumbmer = ArrayNumbers();

            for (int i = 0; i < arraysNumbmer.Length; i++)
            {
                if (arraysNumbmer[i] % 2 == 0)
                {
                    Console.WriteLine(arraysNumbmer [i]);
                }
            }    
        }
        static int[] ArrayNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return numbers;

        }
    }
}
/*
    Desarrolla un programa en el que crees e inicialices un array con los
    números del 1 al 10 
    y luego crea otro array donde introducirás los números
    pares contenidos en el primer array

    if (numero % 2 == 0)
    {
        // Es par
    }
*/