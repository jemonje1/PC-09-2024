//Código Ejercicio Javier Monje 1260524
using System;
namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número positivo menor a 1000000");
            int n = int.Parse(Console.ReadLine());
            if (n>999999 || n<=0)
            {
                Console.WriteLine("Por favor ingrese un número positivo que no sea mayor a 1000000");
            }
            else
            {
               if (Primo (n))
               {
                Console.WriteLine($"El número {n} es primo");
               }
               else
               {
                Console.WriteLine($"El número {n} no es primo");
               }
            }
        }
        static bool Primo(int n)
        {
            if (n==1)
            {
                return false;
            }
            if(n==2)
            {
                return true;
            }
            for (int d = 2; d<n; d++)
            {
                if(n % d == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}