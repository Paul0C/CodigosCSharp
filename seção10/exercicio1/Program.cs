// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using exercicio1.Entities;

List<Product> listProducts = new List<Product>();

Console.Write("Enter the number of products:");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)?");
    char c = char.Parse(Console.ReadLine());
    Console.Write("Name:");
    string name = Console.ReadLine();
    Console.Write("Price:");
    double price = double.Parse(Console.ReadLine());

    if (c == 'c')
    {
        Product product = new Product(name, price);
        listProducts.Add(product);
    }
    else if (c == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY):");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        Product product = new UsedProduct(name, price, manufactureDate);
        listProducts.Add(product);
    }
    else
    {
        Console.Write("Cunstons Fee:");
        double custonsFee = double.Parse(Console.ReadLine());
        Product product = new ImportedProduct(name, price, custonsFee);
        listProducts.Add(product);
    }



}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("PRICE TAGS:");
foreach (Product item in listProducts)
{
    Console.WriteLine(item.PriceTag());
}

