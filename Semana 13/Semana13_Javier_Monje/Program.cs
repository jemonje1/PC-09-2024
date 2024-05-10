namespace Semana13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombre = new string[4];
            string[] Apellido = new string[4];
            string[] Edad = new string[4];
            string[] Telefono = new string[4];
            for (int n = 0; n < 4; n++)
            {
                Console.WriteLine("Ingrese el nombre de la persona ");
                Nombre[n] = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido de la persona ");
                Apellido [n] = Console.ReadLine();
                Console.WriteLine("Ingrese la edad de la persona ");
                Edad [n]= Console.ReadLine();
                Console.WriteLine("Ingrese el no. de télefono de la persona ");
                Telefono [n]= Console.ReadLine();
                
                for (int i = 1; i<5; i++)
                {
                    Console.WriteLine ("Los datos de la persona"+i);
                    Console.WriteLine (Nombre[n]);
                    Console.WriteLine (Apellido[n]);
                    Console.WriteLine (Edad[n]);
                    Console.WriteLine (Telefono[n]);
                }
            }
        }
    }
}