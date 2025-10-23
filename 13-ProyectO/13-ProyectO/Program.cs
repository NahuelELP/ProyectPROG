using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
                if(opcion >=1 && opcion <=5)
                {
                    switch (opcion)
                    {
                        case 1:
                            AddStudend(alumnos, ref cantidad);
                            break;
                        case 2:
                            UpdateNameShowConsol(cantidad, ref alumnos);
                            break;
                        case 3:
                            List(cantidad, alumnos);
                            break;
                        case 4:
                            GetIdNameShowConsol(ref cantidad, alumnos);
                            break;
                        default:
                            salir = 5;
                            break;
                    }
                }
                else
                {
                    while (opcion <= 0 || opcion >= 5)
                    {
                        Console.WriteLine("No es una opcion a elejir, intentalo de nuevo :/");
                        opcion = int.Parse(Console.ReadLine());
                    }
                }
            }while (salir < 4);
        }
        static void AddStudend(string[]names, ref int cantidad)
        {
            if(cantidad <= 4)
            {
                Console.WriteLine("Ingresa el nombre del alumno:");
                string name = Console.ReadLine();
                names[cantidad] = name;
                cantidad++;
            }
            else
            {
                Console.WriteLine("Lo siento ya no puedes agregar mas alumnos...");
                Console.ReadKey();
            }
            
        }
        static string GetIdName(string name, int cantidad, string[] alumnos)
        {
            string nameGive="No se encontro el nombre ---> "+ name;
            for (int i = 0; i < cantidad; i++)
            {
                if(name == alumnos[i])
                {
                    nameGive = alumnos[i];
                }
            }
            return nameGive;
        }
        static void GetIdNameShowConsol(ref int cantidad, string[] alumnos)
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
                Console.WriteLine(nameSaved);
            }
            Console.ReadKey();
        }
        static string UpdateName(string nameUpd, int cantidad, ref string [] alumnos)
        {
            string nameGive = "No se encontro el nombre ----> " + nameUpd;

            for (int i = 0; i < cantidad; i++)
            {

                if (nameUpd.ToLower() == alumnos[i].ToLower())
                {
                    nameGive = alumnos[i];
                }
            }
            return nameGive;
            /*
                    Console.WriteLine("Alumno encontrado---->" + alumnos[i]);
                    Console.WriteLine("Cambia el nombre como gustes:");
            */
        }
        static void UpdateNameShowConsol(int cantidad, ref string[] alumnos)
        {
            Console.WriteLine("Que nombre queres cambiar?");
            string nameUpd = Console.ReadLine();
            string nameUpdShow = UpdateName(nameUpd, cantidad, ref alumnos);

            if(nameUpdShow.ToLower() == nameUpd.ToLower())
            {
                Console.WriteLine("Nombre encontrado ---> "+nameUpdShow);
                Console.WriteLine("Actualiza el nombre:");

                for(int i =0; i < cantidad;i++)
                {
                    if(nameUpdShow == alumnos[i])
                    {
                        nameUpdShow = Console.ReadLine();
                        alumnos[i] = nameUpdShow;
                    }
                }
            }
            else
            {
                Console.WriteLine(nameUpdShow);
            }
            Console.ReadKey();
        }
        static void List(int cantidad,  string[] alumnos)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(alumnos[i]);
            }
            Console.ReadKey();
        }
    }
}