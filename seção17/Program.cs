// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using seção17.Entities;

Console.Write("Enter full file path:");
string path = Console.ReadLine();

List<Employee> list = new List<Employee>();

Console.Write("Enter salary:");
double salaryLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

list.Add(new Employee("Maria", "maria@gmail.com", 3200.00));
list.Add(new Employee("Alex", "alex@gmail.com", 1900.00));
list.Add(new Employee("Marco", "marco@gmail.com", 1700.00));
list.Add(new Employee("Bob", "bob@gmail.com", 3500.00));
list.Add(new Employee("Anna", "anna@gmail.com", 2800.00));


var Order = list.Where(p => p.Salary > salaryLimit).OrderBy(p => p.Email).Select(p => p.Email);
foreach (string item in Order)
{
    Console.WriteLine(item);
}

var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);

Console.WriteLine("Sum of salary of people whose name starts with 'M':" + sum);

