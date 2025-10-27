using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_ModificadoresAcceso;

namespace ModificadoresAcceso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario marto = new Usuario();
            marto.nombre = "marto";
            marto.IniciarSesion();
        }
    }
}
