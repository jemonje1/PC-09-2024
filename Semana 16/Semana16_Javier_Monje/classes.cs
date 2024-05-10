//Javier Monje 1260524//
using System.Security.AccessControl;
using Classes;

var account = new BankAccount("Javier Monje", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "friend paid me back");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());

// Test that the initial balances must be positive:
//Cambio de error, ahora es que el balance sea de -45
try
{
    var invalidAccount = new BankAccount("inválido", -45);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Excepción, hay un valor negativo");
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
int v = 0;
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