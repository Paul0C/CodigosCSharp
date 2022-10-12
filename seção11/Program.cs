// See https://aka.ms/new-console-template for more information
using seção11.Entities;
using seção11.Entities.Exceptions;

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Balance: ");
    double balance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine());

    Account account = new Account(number, holder, balance, withdrawLimit);

    Console.Write("Enter amount for withdraw: ");
    double withdraw = double.Parse(Console.ReadLine());

    account.Withdraw(withdraw);

    Console.WriteLine("New Balance: " + account.Balance);
}
catch (DomainException e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
}