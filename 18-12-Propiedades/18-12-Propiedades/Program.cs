using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_12_Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Propiedades Clas = new Propiedades();
            Propiedades Clas1 = new Propiedades();

            Clas.Nota = 1.2;
            Clas1.NotaFinal = 2.2;

            Console.WriteLine("La nota es : {0}",Clas.Nota);
            Console.WriteLine("La nota final es : {0}", Clas1.NotaFinal);
        }


    }
}
