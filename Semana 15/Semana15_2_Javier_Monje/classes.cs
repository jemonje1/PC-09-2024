//Javier Monje 1260524//
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Classes;

namespace Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool salida = false;
            Console.WriteLine("Bienvenido al banco");
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            int numero = 0;
            Console.WriteLine("Ingrese su número de cuenta");
            numero = int.Parse(Console.ReadLine());
            BankAccount.SAccountNumberSeed(numero);
            Console.WriteLine("Ingrese su tipo de cuenta");
            string tipo = Console.ReadLine();
            Console.WriteLine("Todas las cuentas inician con un balance de 1000.00");
            var account = new BankAccount(nombre, 1000);
            BankAccount.TipoCuenta(account, tipo);
            Console.WriteLine($"Account type {account.Type} no. {account.Number} was created for {account.Owner} with {account.Balance} balance.");
            Console.WriteLine("Ingrese el pago de renta");
            int pago = int.Parse(Console.ReadLine());
            account.MakeWithdrawal(pago, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            Console.WriteLine("Ingrese el depósito");
            int deposito = int.Parse(Console.ReadLine());
            account.MakeDeposit(deposito, DateTime.Now, "friend paid me back");
            Console.WriteLine(account.Balance);
            //Creación del arreglo
            string registrobalance = account.Balance.ToString();
            string registronocuenta = account.Number.ToString();
            string[] arreglo = [registronocuenta, account.Owner, account.Type, registrobalance];
            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine($"Menú de opciones a realizar \n Escriba la letra de la opción \n a) Ver sus datos \n b) salir");
            char opciones = Console.ReadLine().ToLower()[0];
            switch (opciones)
            {
                case 'a':
                    Console.WriteLine("Sus datos para \n Número de cuenta, Nombre, Tipo de cuenta, Balance");
                    foreach (var dato in arreglo)
                    {
                        Console.WriteLine($"{dato}");
                    }
                    break;
                case 'b':
                    Console.WriteLine("Gracias por hacer sus transacciones");
                    salida = true;
                    break;
                default:
                    {
                        Console.WriteLine("Opción no válida, seleccionar otra opción");
                        break;
                    }
            }
            //errores semana 16
            int v = 0;
            int errorcito = 0;
            int errorcito2 = 0;
            try
            {
                errorcito = nombre.Length;
                if (errorcito == 0)
                {
                    throw new ArgumentNullException(nameof(nombre));
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("El nombre no puede ser tipo nulo");
                Console.WriteLine(e.ToString());
            }
            try
            {
                errorcito2 = tipo.Length;
                if (errorcito2 == 0)
                {
                    throw new ArgumentNullException(nameof(tipo));
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Su cuenta no puede ser de tipo nula");
                Console.WriteLine(e.ToString());
            }
            // Test for a negative balance
            // Cambio en el error, ahora es de 800, antes de 750
            try
            {
                account.MakeWithdrawal(800, DateTime.Now, "Intento de mayor del límite");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Excepción obtenido debido a intento de sobrepaso de límite");
                Console.WriteLine(e.ToString());
            }
            /*ERRORES AGREGADOS
error 1, verificar con throw si el valor de la cuenta es entero o no*/
            if (!int.TryParse(account.GetAccountHistory(), out v))
            {
                throw new ArgumentOutOfRangeException("El valor de la cuenta no es un número entero");
            }
            //error 2 para ver si hay valor nulo en GetAccountHistory
            try
            {
                int n = account.GetAccountHistory().Length;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("el valor de la cuenta no contiene algún caracter");
                Console.WriteLine(e.ToString());
            }
        }
    }
}