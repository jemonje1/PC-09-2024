using System;
using System.ComponentModel.Design;

namespace Semana14
{
    class Program
    {
        static int n = 0;
        static int[] array1 = new int[12];
        static void Main(string[] args)
        
        {
            Program program = new Program();
            Console.WriteLine("Bienvenido, Ingrese 12 números enteros");
            for (int i = 0; i < array1.Length; i++)
            {
                n = int.Parse(Console.ReadLine());
                array1[i] = n;
            }
            bool salida = false;
            do
            {
                Console.WriteLine("Ingrese la opción que desee realizar, escogiendo una letra");
                Console.WriteLine("a. Sume los números ingresados");
                Console.WriteLine("b. Promedio de los números ingresados");
                Console.WriteLine("c. Ordene de mayor a menor");
                Console.WriteLine("d. Ordene de menor a mayor");
                Console.WriteLine("e. Cambie el tamaño del arreglo dos posiciones más");
                Console.WriteLine("f. Utilizar un split()");
                Console.WriteLine("g. Salir");
                Char menu = Console.ReadLine().ToLower()[0];
                switch (menu)
                {
                    case 'a':
                        program.a();
                        break;
                    case 'b':
                        program.b();
                        break;
                    case 'c':
                        program.c();
                        break;
                    case 'd':
                        program.d();
                        break;
                    case 'e':
                        program.e();
                        break;
                    case 'f':
                        program.f();
                        break;
                    case 'g':
                        Console.WriteLine("Gracias por usar el programa");
                        salida = true;
                        break;
                    default:
                        Console.WriteLine("Opción no valida, seleccionar otra opción");
                        break;
                }
            }
            while (!salida);
        }
        public void a()
        {
            int total = 0;
            total = array1.Sum();
            Console.WriteLine($"La suma de los números es {total}");
        }
        public void b()
        {
            double promedio = 0.00;
            int suma = 0;
            suma = array1.Sum();
            promedio = suma / array1.Length;
            Console.WriteLine($"El promedio de lus números es {promedio}");
        }
        public void c()
        {
            Array.Sort(array1);
            Console.WriteLine("Los números ordenados de menor a mayor son:");
            foreach (var numeros in array1)
            {
                Console.WriteLine($"{numeros}");
            }
        }
        public void d()
        {
            Array.Reverse(array1);
            Console.WriteLine("Los números ordenados de menor a mayor son:");
            foreach (var numeros in array1)
            {
                Console.WriteLine($"{numeros}");
            }
        }
        public void e()
        {
            Array.Resize(ref array1, array1.Length + 2);
            Console.WriteLine("Ha agregado otros dos espacios a su arreglo, ingrese los nuevos dos valores");
            array1[array1.Length - 2] = Convert.ToInt32(Console.ReadLine());
            array1[array1.Length - 1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su nuevo grupo de números es");
            foreach (var valores in array1)
            {
                Console.WriteLine($"{valores}");
            }
        }
        public void f()
        {            
            string result = String.Join(",", array1);
            string[] array2 = new string[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i].ToString();
            }
            array2 = result.Split(',');
            foreach (string cadena in array2)
            {
                Console.WriteLine(cadena);
            }
        }
    }
}