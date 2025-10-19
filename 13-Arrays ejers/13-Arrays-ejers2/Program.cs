using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Arrays_ejers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysWeek = new string[] { "Lunes", "Martes", "Miercoes", "Jueves", "Viernes", "Sabado", "Domingo" };
            Console.WriteLine("Del 1 al 7 como dia de la semana, que dia tenes libre?");
            int numberEntred = int.Parse(Console.ReadLine());
            Console.WriteLine(daysWeek[numberEntred-1]);
        }

    }
}
/*
    Crea un array y rellénalo con los días de la semana. Luego pide al usuario
    que introduzca un número del 1 al 7 para saber qué día de la semana tiene
    libre en su trabajo y dependiendo del número introducido, debes mostrar
    por consola el día de la semana correspondiente.
*/
