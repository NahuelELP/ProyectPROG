using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ModificadoresAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario nahuel = new Usuario();
            nahuel.nombre = "nahuel";
            nahuel.IniciarSesion();

        }
    }
    public class Usuario
    {
        public string nombre;
        public string email;
        public string contraseña;

        public void IniciarSesion()
        {
            Console.WriteLine("El usuario {0} acaba de iniciar sesion", nombre);
        }
        public void CerrarSesion()
        {
            Console.WriteLine("El usuario {0} acaba de iniciar sesion", nombre);
        }
        public void CambiarContraseña()
        {
            Console.WriteLine("El usuario {0} acaba de cambiar su contraseña", nombre);
        }
    }
}
