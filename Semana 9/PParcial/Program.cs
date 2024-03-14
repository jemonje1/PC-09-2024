//Javier Monje Programa Parcial, Carnet 1260524
using System;
namespace PParcial
{
    class PParcial
    {
        static void Main(string[] args)
        {
            //Entradas, las cuales son el permitir ingresar nombre y edad//
            string nombre = "";
            int edad = 0;
            int m = 0;
            int d = 0;
            int h = 0;
            /*Los procesos son, la asignación del nombre, edad, y también las conversión de los meses, días y horas.
            También el uso de switch para determinar qué salida.*/
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            m = edad * 12;
            d = edad*365;
            h = d*24;
            /*Las salidas son los resultados que brinda el programa, en este caso, determinar el ciclo de la vida donde
            el usuario se encuentra y mostrar las conversiones realizadas.*/
            switch (edad)
            {
                case >= 0 and <=5:
                Console.WriteLine($"{nombre} ({edad} años). Usted se encuentra en la Primera Infancia según el ciclo de la vida. Ha vivido {m} meses, {d} días, o {h} horas");
                break;

                case >= 6 and <=11:
                Console.WriteLine($"{nombre} ({edad} años). Usted se encuentra en la Infancia según el ciclo de la vida. Ha vivido {m} meses, {d} días, o {h} horas");
                break;

                case >=12 and <=18:
                Console.WriteLine($"{nombre} ({edad} años). Usted se encuentra en la Adolescencia según el ciclo de la vida. Ha vivido {m} meses, {d} días, o {h} horas");
                break;

                case >= 19 and <=25:
                Console.WriteLine($"{nombre} ({edad} años). Usted se encuentra en la Juventud según el ciclo de la vida. Ha vivido {m} meses, {d} días, o {h} horas");
                break;

                case >= 26 and <=59:
                Console.WriteLine($"{nombre} ({edad} años). Usted se encuentra en la Adultez según el ciclo de la vida. Ha vivido {m} meses, {d} días, o {h} horas");
                break;

                case >= 60:
                Console.WriteLine($"{nombre} ({edad} años). Usted es una Persona Mayor según el ciclo de la vida. Ha vivido {m} meses, {d} días, o {h} horas");
                break;
            }
        }
    }
}
