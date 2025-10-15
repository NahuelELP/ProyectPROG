using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contraseña = "nahu1234";
            Console.WriteLine("Pone tu contraseña");
            string Contra= Console.ReadLine();

            bool Resultado = string.Equals(contraseña, Contra, StringComparison.CurrentCultureIgnoreCase);
            
            if(Resultado == true)
            {
                Console.WriteLine("Contraseña correcta");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
            }
        }
    }
}
//Realizar un programa que pida por consola una contraseña y luego evaluar
//con el operador de comparación correspondiente para verificar si es igual a
//la introducida por teclado.
//Pista: Puedes usar el operador de igualdad que vimos en uno de los videos
//pero también existe un método de la clase String llamado Equals() el cual
//es ideal para comparar dos cadenas de texto. Puedes consultar la
//documentación oficial de .Net para ver cómo funciona.

//En una empresa se recibe un porcentaje de bono anual dependiendo de
//cuantos años tenga el empleado laborando. Si el empleado tiene más de un
//año laborando en la empresa, recibirá un bono del 15% de su mensualidad,
//si tiene entre 2 y 5 años, recibirá un bono del 20% y si tiene más de 5 años,
//entonces su bono será del 25%. Realiza un programa que pida por consola
//dos datos:
// La cantidad de años que tienes trabajando en la empresa
// Tu salario mensual
//Deberás realizar este programa con condicionales if-else y deberás mostrar
//al final la suma de tu mensualidad más el bono.
