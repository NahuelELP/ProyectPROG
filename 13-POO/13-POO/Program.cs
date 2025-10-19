using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ALUMNOS = 5; // Tamaño máximo del array
            string[] nombres = new string[MAX_ALUMNOS];
            double[] promedios = new double[MAX_ALUMNOS];
            int cantidadAlumnos = 0;
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("===== GESTOR DE ALUMNOS =====");
                Console.WriteLine("1. Agregar alumno");
                Console.WriteLine("2. Mostrar todos los alumnos");
                Console.WriteLine("3. Buscar alumno por nombre");
                Console.WriteLine("4. Mostrar mejor promedio");
                Console.WriteLine("5. Salir");
                Console.Write("Elegí una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        if (cantidadAlumnos < MAX_ALUMNOS)
                        {
                            AgregarAlumno(nombres, promedios, cantidadAlumnos);
                        }
                        break;

                    case "2":
                        MostrarAlumnos(nombres, promedios, cantidadAlumnos);
                        break;

                    case "3":
                        BuscarAlumno(nombres, promedios, cantidadAlumnos);
                        break;

                    case "4":
                        MostrarMejorPromedio(nombres, promedios, cantidadAlumnos);
                        break;

                    case "5":
                        salir = true;
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine("\nPresioná una tecla para continuar...");
                Console.ReadKey();
            }
        }

        // MÉTODO 1: Agregar alumno
        static void AgregarAlumno(string[] nombres, double[] promedios, int cantidad)
        {
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();

            double sumaNotas = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Ingrese nota {i}: ");
                double nota = double.Parse(Console.ReadLine());
                sumaNotas += nota;
            }

            double promedio = sumaNotas / 3;

            nombres[cantidad] = nombre;
            promedios[cantidad] = promedio;
            cantidad++;

            Console.WriteLine($"Alumno {nombre} agregado con promedio {promedio:F2}.");
        }

        // MÉTODO 2: Mostrar todos los alumnos
        static void MostrarAlumnos(string[] nombres, double[] promedios, int cantidad)
        {
            if (cantidad == 0)
            {
                Console.WriteLine("No hay alumnos registrados.");
                return;
            }

            Console.WriteLine("\n===== LISTA DE ALUMNOS =====");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"{i + 1}. {nombres[i]} - Promedio: {promedios[i]:F2}");
            }
        }

        // MÉTODO 3: Buscar alumno por nombre
        static void BuscarAlumno(string[] nombres, double[] promedios, int cantidad)
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscado = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (nombres[i].ToLower() == nombreBuscado.ToLower())
                {
                    Console.WriteLine($"Alumno: {nombres[i]} - Promedio: {promedios[i]:F2}");
                    encontrado = true;

                    if (promedios[i] >= 6)
                        Console.WriteLine("Estado: Aprobado ✅");
                    else
                        Console.WriteLine("Estado: Reprobado ❌");
                }
            }

            if (!encontrado)
                Console.WriteLine("Alumno no encontrado.");
        }

        // MÉTODO 4: Mostrar mejor promedio
        static void MostrarMejorPromedio(string[] nombres, double[] promedios, int cantidad)
        {
            if (cantidad == 0)
            {
                Console.WriteLine("No hay alumnos registrados.");
                return;
            }

            double mejorPromedio = promedios[0];
            string mejorAlumno = nombres[0];

            for (int i = 1; i < cantidad; i++)
            {
                if (promedios[i] > mejorPromedio)
                {
                    mejorPromedio = promedios[i];
                    mejorAlumno = nombres[i];
                }
            }

            Console.WriteLine($"\nEl mejor alumno es {mejorAlumno} con promedio {mejorPromedio:F2}");
        }
    }
}
