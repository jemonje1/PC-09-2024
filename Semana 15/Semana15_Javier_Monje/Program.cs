using System;
using Microsoft.VisualBasic.FileIO;
public class Monje
{
    int numero;
    string cadena;
    int n;
    public static void Main()
    {
        Monje objetoProgram = new Monje(0, "hola", 0);
        int opcion;
        bool salida = false;
        string entrada;
        Console.WriteLine("Bienvenido, ingrese a la opción que desee entrar en el menú");
        do
        {
        Console.WriteLine("1. Ingreso de valores");
        Console.WriteLine("2. Mostrar");
        Console.WriteLine("3. Salir");
        entrada = Console.ReadLine();
        if (!int.TryParse(entrada, out opcion))
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
            return;
        }

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingreso de valores");
                objetoProgram.Ingreso();
                break;
            case 2:
                Console.WriteLine("Mostrar valores");
                objetoProgram.show();
                break;
            case 3:
                Console.WriteLine("Apagando . . .");
                salida = true;
                break;
            default:
                Console.WriteLine("Opción no válida. Debe ingresar un número entre 1 y 3.");
                break;
        }
        } while (!salida);
    }

    Monje(int numero, string cadena, int n)
    {
        this.numero = numero;
        this.cadena = cadena;
        this.n = n;
    }
    void show()
    {
        Console.WriteLine(this.numero);
        Console.WriteLine(this.cadena);
        Console.WriteLine(this.n);
    }
    void Ingreso()
    {
        Console.WriteLine("Ingrese un nuevo valor para numero");
        numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un nuevo valor para cadena");
        cadena = Console.ReadLine();
        Console.WriteLine("Ingrese un nuevo valor para n");
        n = int.Parse(Console.ReadLine());
    }
}