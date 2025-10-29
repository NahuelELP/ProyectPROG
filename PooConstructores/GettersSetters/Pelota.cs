using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    internal class Pelota
    {
        private double peso;
        private string color;

        public Pelota()//Valores por defecto del constructor
        {
            peso = 150;
            color = "Blanco";
        }
        public void SetPeso(double peso)
        {
            this.peso = peso;
        }
        public double GetPeso()
        {
            return this.peso;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetColor()
        {
            return this.color;
        }
        public void InfoPelota()
        {
            Console.WriteLine("Peso: {0}Gramos - Color: {1}",peso, color);
        }
    }
}
