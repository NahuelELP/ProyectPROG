using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ProyectO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salir = 0;
            string[] alumnos = new string[0];
            double[] notePromed= new double[0];
            int opcion = 0;
            int cantidad = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("===== GESTOR DE ALUMNOS =====");
                Console.WriteLine("1. Agregar alumno");
                Console.WriteLine("2. Mostrar todos los alumnos");
                Console.WriteLine("3. Buscar alumno por nombre");
                Console.WriteLine("4. Mostrar mejor promedio");
                Console.WriteLine("5. Salir");
                Console.Write("Elegí una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                            AddStudend(alumnos, notePromed,cantidad);
                        break;
                    case 2:
                        for(int i= 0;i < alumnos.Length;i++)
                        {
                            Console.WriteLine(alumnos[i]);
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:   
                        break;
                    default:
                        salir = 5;
                        break;
                }
            }while (salir < 5);
        }
        static void AddStudend(string[]name, double[]notesProm, int cantidad)
        {
            Console.WriteLine("Ingresa el nombre del alumno:");
            string names= Console.ReadLine();
            double sumNotas = 0;
                for (int i= 0; i < 3;i++)
                {
                    Console.WriteLine("Nota :"+ (i+1));
                    double note = double.Parse(Console.ReadLine());
                    sumNotas += note;
                }
            double notas = sumNotas / 3;
            notesProm[cantidad] = notas;
            name[cantidad] = names;
            cantidad++;
        }
        
    }
}
/*
            Console.Clear();
            Console.WriteLine("===== GESTOR DE ALUMNOS =====");
            Console.WriteLine("1. Agregar alumno");
            Console.WriteLine("2. Mostrar todos los alumnos");
            Console.WriteLine("3. Buscar alumno por nombre");
            Console.WriteLine("4. Mostrar mejor promedio");
            Console.WriteLine("5. Salir");
            Console.Write("Elegí una opción: ");
 */
