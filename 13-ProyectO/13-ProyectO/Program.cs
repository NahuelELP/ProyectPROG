using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _13_ProyectO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salir = 0;
            string[] alumnos = new string[5];
            int opcion = 0;
            int cantidad = 0;
            do
            {
                /*
                    Crear 4 usuarios
                    Listar (Corroborar que figuren)
                    Eliminar (Corroborar que ya no figure) que usuario./no es el alumno =otra vez/ Nombres Mays.Mins
                    Actualizar (Corroborar que se actualice bien)
                 */
                Console.Clear();
                Console.WriteLine("===== GESTOR DE ALUMNOS =====");
                Console.WriteLine("1. Agregar alumno");
                Console.WriteLine("2. Actualizar");
                Console.WriteLine("3. Listar Todos");
                Console.WriteLine("4. Traer Por ID");
                Console.WriteLine("5. Salir");
                Console.Write("Elegí una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                            AddStudend(alumnos, ref cantidad);
                        break;
                    case 2:
                        Console.WriteLine("Que nombre queres cambiar?");
                        string nameUpd = Console.ReadLine();
                        UpdateName(nameUpd, cantidad,ref alumnos);
                        Console.ReadKey();
                        break;
                    case 3:
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine(alumnos[i]);
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        GetIdNameNextStep(ref cantidad, alumnos);
                        break;
                    default:
                        salir = 5;
                        break;
                }
            }while (salir < 4);
        }
        static void AddStudend(string[]names, ref int cantidad)
        {
            Console.WriteLine("Ingresa el nombre del alumno:");
            string name= Console.ReadLine();
            names[cantidad] = name;
            cantidad++;
        }
        static string GetIdName(string name, int cantidad, string[] alumnos)
        {
            string nameGive="No se encontro el nombre "+ name;
            for (int i = 0; i < cantidad; i++)
            {
                if(name == alumnos[i])
                {
                    nameGive = alumnos[i];
                }
            }
            return nameGive;
        }
        static void GetIdNameNextStep(ref int cantidad, string[] alumnos)
        {
            Console.WriteLine("Cual es el nombre que queres buscar?");
            string nameSherch = Console.ReadLine();
            string nameSaved = GetIdName(nameSherch, cantidad, alumnos);
            if (nameSaved == nameSherch)
            {
                Console.WriteLine("Alumno encontrado ----> " + nameSaved);
            }
            else
            {
                Console.WriteLine("Este alumno no se encuentra ----> " + nameSaved);
            }
            Console.ReadKey();
        }
        static void UpdateName(string nameUpd, int cantidad, ref string [] alumnos)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (nameUpd == alumnos[i])
                {
                    Console.WriteLine("Alumno encontrado---->" + alumnos[i]);
                    Console.WriteLine("Cambia el nombre como gustes:");
                    string newName = Console.ReadLine();
                    alumnos[i] = newName;
                    break;
                }
                else
                {
                    Console.WriteLine("No se pudo encontrar a ningun alumno llamdo: " + nameUpd);
                    break;
                }
            }
        }
    }
}