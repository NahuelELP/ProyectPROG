using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Tanque : Personajes, IAtacar, IDefensa
    {
        public Tanque(int edad, string nombre, string roll, string genero) : base(edad, nombre, roll, genero)
        {
        }
        public void Atacar()
        {

        }
        public void Defensa()
        {

        }
    }
}
