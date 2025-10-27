using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1_27_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora samsung = new Computadora();
            samsung.marca = "samsung";
            samsung.añoFabricacion = 2024;
            samsung.ram = 4;
            samsung.TransferenciaDeInformacion();
            samsung.MostrarInfoCompu();

            Computadora Appel = new Computadora();
            Appel.marca = "Appel";
            Appel.añoFabricacion = 2020;
            Appel.ram = 1;
            Appel.TransferenciaDeInformacion();
            Appel.MostrarInfoCompu();
        }
    }
    class Computadora
    {
        public string marca;
        public int añoFabricacion;
        public int ram;
        public bool laptop;

        public void On()
        {
            Console.WriteLine("Encendido");
        }
        public void Off()
        {
            Console.WriteLine("Apagado");
        }
        public void TransferenciaDeInformacion()
        {
            if (ram < 2)
            {
                Console.WriteLine("Esta compu es lenta");
            }
            else
            {
                Console.WriteLine("La compu es rapida");
            }
        }
        public void MostrarInfoCompu()
        {
            Console.WriteLine(marca +" "+ añoFabricacion +" "+ ram);

        }
    }
}
