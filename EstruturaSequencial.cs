using System.Globalization;

/*
string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade =  30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos:");
Console.WriteLine($"{produto1},cujo preço é $ {preco1:F2}");
Console.WriteLine($"{produto2},cujo preço é $ {preco2}");

Console.WriteLine($"Registro:{idade} anos de idade, código {codigo} e gênero: {genero}");

Console.WriteLine($"Medida com oito casas decimais:{medida:F8}");
Console.WriteLine($"Arredondado três casas decimais:{medida:F3}");
Console.WriteLine("Separador decimal invariant culture:"+medida.ToString("F3", CultureInfo.InvariantCulture));
*/

/* 
Console.WriteLine("Insira dois valores inteiros para se obter a soma deles:");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int soma = a + b;

Console.WriteLine("A soma dos dois valores inseridos é:" + soma);
*/

/*
Console.WriteLine("Insira o valor do raio de um círculo para se obter o valor da área do mesmo:");

double raio = double.Parse(Console.ReadLine());
double pi = 3.14159;
double area = pi * (raio*raio);

Console.WriteLine($"O valor da área do círculo com quatro casas decimais é:{area:F4}");
*/

/*
Console.WriteLine("Insira quatro números inteiros:");

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
int D = int.Parse(Console.ReadLine());

int diferenca = (A*B - C*D);

Console.WriteLine("A diferença do produto de A e B pelo produto de C e D:" + diferenca);
*/

/*
Console.WriteLine("Insira o número de um funcionário,suas horas trabalhadas e o valor da hora:");

int numero = int.Parse(Console.ReadLine());
double horas = double.Parse(Console.ReadLine());
double valorHora = double.Parse(Console.ReadLine());
double salario = horas * valorHora;

Console.WriteLine("Number = " + numero);
Console.WriteLine("Salary = $" + salario.ToString("F2"));
*/

/*
Console.WriteLine("Insira o código de duas peças,a quantidade de cada e o preço delas:");

Console.WriteLine("Código,quantidade e preço:");
string[] vet1 = Console.ReadLine().Split(' ');
int codigo1 = int.Parse(vet1[0]);
int quantidade1 = int.Parse(vet1[1]);
double preco1 = double.Parse(vet1[2]);
double precos1 = preco1 * quantidade1;

Console.WriteLine("Código,quantidade e preço:");
string[] vet2 = Console.ReadLine().Split(' ');
int codigo2 = int.Parse(vet2[0]);
int quantidade2 = int.Parse(vet2[1]);
double preco2 = double.Parse(vet2[2]);
double precos2 = preco2 * quantidade2;

Console.WriteLine("Total a pagar:$" + (precos1 + precos2).ToString("F2", CultureInfo.InvariantCulture));
*/

/*
double trianguloRetangulo, circulo, trapezio, quadrado, retangulo;

Console.WriteLine("Insira 3 valores A,B e C para se obter o valor da área do triângulo retângulo,círculo,trapézio,quadrado e retângulo:");

string[] valores = Console.ReadLine().Split(' ');
double a = double.Parse(valores[0]);
double b = double.Parse(valores[1]);
double c = double.Parse(valores[2]);

trianguloRetangulo = (a * c) / 2;
circulo = 3.14159 * (c*c);
trapezio = (a+b)*c / 2;
quadrado = b * b;
retangulo = a * b;

Console.WriteLine("Área do triângulo retângulo:" + trianguloRetangulo.ToString("F3"));
Console.WriteLine("Área do círculo:" + circulo.ToString("F3"));
Console.WriteLine("Área do trapézio:" + trapezio.ToString("F3"));
Console.WriteLine("Área do quadrado:" + quadrado.ToString("F3"));
Console.WriteLine("Área do retângulo:" + retangulo.ToString("F3"));
*/
