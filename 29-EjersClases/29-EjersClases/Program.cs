using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _29_EjersClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MENÚ BANCO ===");
            Console.WriteLine("Crearteu una cuenta de Banco BBVA ;)");
            Console.WriteLine("Nombre del Titular de la cuenta: ");
            string nombreTitutal = Console.ReadLine();
            Console.WriteLine("Saldo de la Cuenta: ");
            double saldoCuenta = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de la Cuenta de banco: ");
            int numDeCuenta = int.Parse(Console.ReadLine());
            CuentaBancaria CuentaDeBanco = new CuentaBancaria(nombreTitutal, saldoCuenta, numDeCuenta);
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("\n=== MENÚ BANCO ===");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Mostrar información");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Intrdouce dinero: ");
                        double dineroIntroducido = double.Parse(Console.ReadLine());
                        CuentaDeBanco.IntroducirDinero(dineroIntroducido);
                        Console.WriteLine("El dinero introducido fue de: {0} y el monto acutal es de {1}",dineroIntroducido,saldoCuenta = CuentaDeBanco.GetSaldo());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Cuando dinero kiere retirar?: ");
                        double dineroRetirado= double.Parse(Console.ReadLine());
                        Console.WriteLine("El dinero retirado fue de: {0} y el saldo actual es de: {1}",dineroRetirado,saldoCuenta=CuentaDeBanco.RetiraDinero(dineroRetirado));
                        Console.ReadKey();
                        break;
                    case 3:
                        /*CuentaDeBanco.SetTitular(nombreTitutal);*/
                        Console.WriteLine(CuentaDeBanco.GetTitular());
                        /*CuentaDeBanco.SetSaldo(saldoCuenta);*/
                        Console.WriteLine("Su cuenta tiene: {0} Euros",saldoCuenta = CuentaDeBanco.GetSaldo());
                        Console.ReadKey();
                        break;
                    case 4:
                        salir = true;
                        Console.WriteLine("Gracias por usar el sistema.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
/*
    programa que modele una cuenta bancaria. Cada cuenta tiene un titular, un número de cuenta y un saldo.

    El usuario podrá depositar dinero, retirar dinero y ver la información de la cuenta.

    Crear una clase CuentaBancaria: titular, numero de cuenta, saldo
    Un constructor que reciba el titular, número de cuenta y saldo inicial.

    Propiedades públicas (get/set) para leer el titular y número de cuenta, pero
    El número de cuenta solo debe poder leerse, no modificarse.

    El titular puede modificarse.
 */
