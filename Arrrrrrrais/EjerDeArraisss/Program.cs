using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerDeArraisss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas notas anuales tuviste");

            int number = int.Parse(Console.ReadLine());
            double[] NotesSchool = new double[number];

            AskForNumber(NotesSchool);

            Console.WriteLine("Tu promedio fue:" + Calculation(NotesSchool));
        }
        static void AskForNumber(double[] notes)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Ingresa las "+notes.Length+" notas:");
                double NoteSchool= double.Parse(Console.ReadLine());
                notes[i] = NoteSchool;
                i++;

            } while (i < notes.Length);
        }
        static double Calculation(double[] notes)
        {
            double totalNotes = 0;
            double average = 0;

            for (int i = 0; i < notes.Length; i++)
            {
                totalNotes += notes[i];
                

            }
            return average = totalNotes / notes.Length;

        }
    }
}
