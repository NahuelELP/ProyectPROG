using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_12_Herenecias
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Perro koda = new Perro(4,true, true,"Naranja");
            Gato lux = new Gato(4, true, true,"blanco","liso");
            Hamster hamster = new Hamster(4, true, true, "multicolor", 23);

            Mascota[] mascotas = new Mascota[3];

            mascotas[0] = new Perro(4, true, true, "Naranja");
            mascotas[1] = new Gato(4, true, true, "blanco", "liso");
            mascotas[2] = new Hamster(4, true, true, "multicolor", 23);

            Perro perro1 = (Perro)mascotas[0];
            Gato gato1 = (Gato)mascotas[1];
            Hamster hamster1 = (Hamster)mascotas[2];

            perro1.Ladrar();
            gato1.Maullar();
            hamster1.Gruñir();
        }
    }
}
