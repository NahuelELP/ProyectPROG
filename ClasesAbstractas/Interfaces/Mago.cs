using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Mago : Personajes, IAtacar, IDefensa
    {
        public int DañoMagico { get; set; }
        public int DefensaBase { get; set; }
        public Mago(int edad, string nombre, string roll, string genero) : base(edad, nombre, roll, genero)
        {
            DañoMagico = (int)EPropPersonajes.AtaqueBaseMago;
            DefensaBase = (int)EPropPersonajes.DefensaBase;
        }
        public void Atacar()
        {
            Console.WriteLine("Daño magico: {0}\nDaño base: {1}\nDaño total: {2}", DañoMagico, Ataque,(DañoMagico+Ataque));
        }
        public void Defensa()
        {
            Console.WriteLine("Defensa:{0}", DefensaBase);
        }
    }
}
