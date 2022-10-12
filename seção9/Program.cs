// See https://aka.ms/new-console-template for more information

using seção9.Entities;
using seção9.Entities.Enums;

Console.WriteLine("Enter client data:");
Console.Write("Name:");
string name = Console.ReadLine();
Console.Write("Email:");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY):");
DateTime birthdate = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, birthdate);


Console.WriteLine("Enter order data:");
Console.Write("Status:");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.Write("How many items to this order?");
int quant = int.Parse(Console.ReadLine());


Order order = new Order(DateTime.Now, status, client);

for (int i = 1; i <= quant; i++)
{
    Console.WriteLine("Enter #" + i + " item data:");
    Console.Write("Product name:");
    string productName = Console.ReadLine();
    Console.Write("Product price:");
    double price = double.Parse(Console.ReadLine());
    Console.Write("Quantity:");
    int num = int.Parse(Console.ReadLine());
    Product product = new Product(productName, price);
    OrderItem orderItem = new OrderItem(num, price, product);
    order.AddItem(orderItem);
}

Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);






