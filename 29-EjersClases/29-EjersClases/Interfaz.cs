using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _29_EjersClases
{
    internal class Interfaz
    {
        public void NombreDelTitular(string nombreTitular)
        {
            bool NombreValido = false;
          
            do
            {
                if (!string.IsNullOrWhiteSpace(nombreTitular) && nombreTitular.Length >= 3 && nombreTitular.Length <= 15 && Regex.IsMatch(nombreTitular, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ]+$"))   // no vacío // límite de letras // solo letras, sin espacios
                {
                    nombreTitular = nombreTitular.ToLower();
                    Console.WriteLine("Nombre válido: " + nombreTitular);
                    NombreValido = true;
                }
                else
                {
                    Console.WriteLine("Intente de nuevo ----> Nombre del Titular de la cuenta:");
                    nombreTitular = Console.ReadLine();
                    NombreValido = false;
                }
            } while (!NombreValido);
        }
    }
}
