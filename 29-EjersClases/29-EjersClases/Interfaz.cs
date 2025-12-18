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
        public void NumeroDeCuenta(int numDeCuenta)
        {
            bool NumeroCuentaValido = false;
            do
            {
                if (numDeCuenta > 0 && numDeCuenta < 1000000000)
                {
                    NumeroCuentaValido = true;
                }
                else
                {
                    Console.WriteLine("Numero de cuenta incorrecto");
                    Console.WriteLine("Intente de nuevo ----> Numero de la Cuenta de banco: ");
                    numDeCuenta = int.Parse(Console.ReadLine());
                    NumeroCuentaValido = false;
                }
            } while (!NumeroCuentaValido);

        }
        public void SaldoDeLaCuenta(double saldoCuenta)
        {
            bool SaldoValido = false;
            do
            {
                if (saldoCuenta <= 500000 && saldoCuenta >= 0)
                {
                    SaldoValido = true;
                }
                else
                {
                    Console.WriteLine("Saldo incorrecto Intente de nuevo");
                    Console.WriteLine("Intente de nuevo ----> Saldo de la Cuenta: ");
                    saldoCuenta = int.Parse(Console.ReadLine());
                    SaldoValido = false;
                }
            } while (!SaldoValido);
        }
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
