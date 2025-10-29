using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pelota1 = new Pelota();

            pelota1.SetPeso(200);
            Console.WriteLine(pelota1.GetPeso());
            pelota1.SetColor("azul");
            Console.WriteLine(pelota1.GetColor());

            pelota1.InfoPelota();
            
        }
    }
}
