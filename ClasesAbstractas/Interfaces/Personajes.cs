using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Personajes
    {
        public int Ataque { get; set; }
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Roll { get; set; }
        public string Genero { get; set; }
        public Personajes(int edad, string nombre, string roll, string genero)
        {
            Edad = edad;
            Nombre = nombre;
            Roll = roll;
            Genero = genero;
            Ataque = (int)EPropPersonajes.AtaqueBase;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, como estas?");
        }

    }
}
