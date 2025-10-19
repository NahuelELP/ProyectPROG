using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Arrays_ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos clientes queres crear?");
            int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el nombre y edad de él/los cliente/s" );
                NewClinets(number);
        }
        static void NewClinets(int num)
        {
            string[] names = new string[num];
            int[] age= new int[num];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("ingrese el nombre del :"+ (i+1));
                names[i] = Console.ReadLine();
                Console.WriteLine("Ingresa la edad de :" + names[i]);
                age[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("nombre:"+names[i] + " edad:" +age[i]);
            }
        }

    }
}
/*
    Haz un programa que muestre por consola una lista de clientes con sus
    edades.

    Los clientes y edades deben ser introducidos por teclado y deben
    ser almacenados en arrays (uno para los nombres y otro para las edades).

    La cantidad de clientes debe ser determinada por el propio usuario quién
    deberá introducir este número por teclado y es el que será usado para
    determinar el tamaño de los arrays.
 */
