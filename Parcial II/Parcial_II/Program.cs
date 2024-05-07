using System.Diagnostics.CodeAnalysis;
using System.Runtime;
using System.Security.Cryptography;
using System.Timers;
using Microsoft.VisualBasic;

namespace ParcialII
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Salir = false;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Asignación de notas del curso:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ingrese los nombres de los alumnos");
            string[] nombres = new string[10];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre del alumno {i+1}");
                nombres[i] = Console.ReadLine();
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Ingrese las notas de los alumnos en orden");
            Console.WriteLine("------------------------------------------");
            int[] nota = new int[10];
            for (int i = 0; i < nombres.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Ingresar la nota de {nombres[i]} esta no puede ser mayor de 100, ni menor de 0");
                    nota[i] = Int32.Parse(Console.ReadLine());
                }
                while (nota[i] < 0 || nota[i] > 100);
            }
            do
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Menú de opciones a realizar");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Ingrese la opción a la que desea entrar \n a) Mostrar quienes aprobaron  \n b) Quienes reprobaron \n c) Promedio de notas \n d) Salir");
                char opciones = Console.ReadLine().ToLower()[0];
                switch (opciones)
                {
                    case 'a':
                        for (int a = 0; a > nota.Length; a++)
                        {
                            if (nota[a] >= 65)
                            {
                                Console.WriteLine($"El alumno {nombres[a]} aprobó con nota de {nota[a]}");
                            }
                            else
                            {
                                Console.WriteLine("No aprobó");
                            }
                        }
                        break;
                    case 'b':
                        for (int b = 0; b > nota.Length; b++)
                        {
                            if (nota[b] <= 65)
                            {
                                Console.WriteLine($"El alumno {nombres[b]} reprobó con nota de {nota[b]}");
                            }
                            else
                            {
                                Console.WriteLine("Sí aprobó");
                            }
                        }
                        break;
                    case 'c':
                        int suma = nota[0] + nota[1] + nota[2] + nota[3] + nota[4] + nota[5] + nota[6] + nota[7] + nota[8] + nota[9];
                        int promedio = suma / nota.Length;
                        Console.WriteLine($"El promedio de notas es {promedio}");
                        break;
                    case 'd':
                        Console.WriteLine("Gracias por usar el programa");
                        Salir = true;
                        break;
                    default:
                        Console.WriteLine("Ingrese un valor que el programa acepte");
                        break;
                }
            } while (!Salir);
        }
    }
}