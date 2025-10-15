using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            //Bono = Salario mensual × porcentaje
            //Salario total anual con bono = (Salario mensual × 12) +Bono

            //Si tiene más de 1 año y menos de 2 años, el bono es del 15% del salario mensual
            //Si tiene entre 2 y 5 años(inclusive), el bono es del 20 % del salario mensual
            //Si tiene más de 5 años, el bono es del 25 % del salario mensual
            //Si tiene 1 año o menos, no recibe bono

            Console.WriteLine("Cuantos años tenes en la empresa?");
            double Años= int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto cobras?");
            int Salario = int.Parse(Console.ReadLine());
            double bono;
            double SalarioAnualMasBono;

            if (Años > 1 && Años < 2)
            {
                bono = Salario * 0.15;
                SalarioAnualMasBono = (Salario * 12) + bono;
                Console.WriteLine("tu bono es " + SalarioAnualMasBono);
            }
            else
            {
                if(Años >= 2 && Años <= 5) 
                {
                    bono = Salario * 0.20;
                    SalarioAnualMasBono = (Salario * 12) + bono;
                    Console.WriteLine("tu bono es " + SalarioAnualMasBono);
                }
                else
                {
                    if(Años > 5)
                    {
                        bono = Salario * 0.25;
                        SalarioAnualMasBono = (Salario * 12) + bono;
                        Console.WriteLine("tu bono es "+SalarioAnualMasBono);
                    }
                    else
                    {
                        Console.WriteLine("No recibis bono");
                    }
                }
            }
        }
    }
}
