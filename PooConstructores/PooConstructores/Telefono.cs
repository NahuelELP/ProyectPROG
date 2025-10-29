using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooConstructores
{
    internal class Telefono
    {
        private int memoria;
        private int ram;
        private double peso;
        private int megaPix;
        private bool flashFron;

        public Telefono()//Valor por defecto ueda en 0 si no inicializo las variables dentro del constructor
        {
            memoria = 128;
            ram = 6;
            peso = 150;
            megaPix = 28;
            flashFron = false;
        }
        public Telefono(int memoria, int ram, double peso, int megaPix, bool flashFron)
        {
            this.memoria = memoria;
            this.ram = ram;
            this.peso = peso;
            this.megaPix = megaPix;
            this.flashFron = flashFron;
        }
        public int InfoMemoria()
        {
            return this.memoria;
        }
    }
}
