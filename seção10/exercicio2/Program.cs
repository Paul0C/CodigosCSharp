// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using exercicio2.Entities;

List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write("Individual or company (i/c)? ");
    char c = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual Income: ");
    double anualIncome = double.Parse(Console.ReadLine());
    if (c == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine());
        list.Add(new Individual(name, anualIncome, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployeers = int.Parse(Console.ReadLine());
        list.Add(new Company(name, anualIncome, numberOfEmployeers));
    }
}

Console.WriteLine("TAXES PAID:");
double sum = 0;

foreach (TaxPayer item in list)
{
    Console.WriteLine(item.Name + ": $ " + item.Tax().ToString("F2"));
    sum += item.Tax();
}

Console.WriteLine("TOTAL TAXES: $ " + sum);
