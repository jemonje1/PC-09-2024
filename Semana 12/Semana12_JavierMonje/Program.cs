//Semana 12 Javier Monje
using System.Reflection;
namespace semana_12
{
    class Program
    {
        //llamada al método principal
        static void Main(string[] args)
        {
            menu();
        }
        //declaración de menú
        static void menu( )
        {
            //asignación de variables para a y b
            Console.WriteLine("Semana 12");
            Console.WriteLine("Ingrese un número");
            string n1 = (Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número a operar");
            string n2 = (Console.ReadLine());
            int a;
            int b;
            if (tipo(n1) && tipo(n2))
            {
                a = int.Parse(n1);
                b = int.Parse(n2);
                Console.WriteLine("Coloque la opción que quiera realizar");
                Console.WriteLine(" a) Multiplicación");
                Console.WriteLine(" b) suma");
                Console.WriteLine(" c) Resta ");
    
                //llamada de funciones suma, resta y multiplicación según la opción que se elija
                char opcion = Console.ReadLine().ToLower()[0];
                switch (opcion)
                {
                    case 'a':
                        Console.WriteLine("El resultado es :" + Multiplicacion(a, b));
                        Console.ReadKey();
                    break;
                    case 'b':
                        Console.WriteLine("El resultado es :" + suma(a, b));
                        Console.ReadKey();
                    break;
                    case 'c':
                        Console.WriteLine("El resultado es :" + resta(a, b));
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("La opción seleccionada no es válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Porfavor, ingrese dos números enteros");
            }
        }
        //funcinoes multiplicacion, suma, resta
        public static int Multiplicacion(int a, int b)
        {
            int resultado = 0;
            resultado = a * b;
            return resultado;
        }
        public static int suma(int a, int b)
        {
            int resultado = 0;
            resultado = a + b;
            return resultado;
        }
        public static int resta(int a, int b)
        {
            int resultado = 0;
            resultado = a - b;
            return resultado;
        }
        public static bool tipo(string letras)
        {
            return int.TryParse(letras, out _);
        }
    }
}