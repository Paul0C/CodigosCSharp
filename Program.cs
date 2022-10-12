// See https://aka.ms/new-console-template for more information

/*
using testeC_;

Pessoa a, b;

a = new Pessoa();
b = new Pessoa();

Console.WriteLine("Insira os dados da primeira pessoa:");
a.Nome = Console.ReadLine();
a.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("Insira os dados da segunda pessoa:");
b.Nome = Console.ReadLine();
b.Idade = int.Parse(Console.ReadLine());

if (a.Idade > b.Idade)
{
    Console.WriteLine("Pessoa mais velha:" + a.Nome);
}
else if (b.Idade > a.Idade)
{
    Console.WriteLine("Pessoa mais velha:" + b.Nome);
}
else
{
    Console.WriteLine("As duas pessoas tem a mesma idade.");
}
*/

/*
using testeC_;

Funcionario a, b;

a = new Funcionario();
b = new Funcionario();

Console.WriteLine("Insira os dados do primeiro funcionário.");
Console.Write("Nome:");
a.Nome = Console.ReadLine();
Console.Write("Salario:");
a.Salario = double.Parse(Console.ReadLine()); 

Console.WriteLine("Insira os dados do segundo funcionário.");
Console.Write("Nome:");
b.Nome = Console.ReadLine();
Console.Write("Salario:");
b.Salario = double.Parse(Console.ReadLine()); 

double salarioMedio = (a.Salario + b.Salario) / 2.0;

Console.WriteLine("Salário médio:" + salarioMedio.ToString("F2"));
*/

/*
using testeC_;

Retangulo a;

a = new Retangulo();

Console.WriteLine("Insira a largura e a altura de um retângulo.");
Console.Write("Largura:");
a.Largura = double.Parse(Console.ReadLine());
Console.Write("Altura:");
a.Altura = double.Parse(Console.ReadLine());
Console.WriteLine("Área:" + a.Area().ToString("F2"));
Console.WriteLine("Perímetro:" + a.Perimetro().ToString("F2"));
Console.WriteLine("Diagonal:" + a.Diagonal().ToString("F2"));
*/

/*
using testeC_;

Aluno aluno;

aluno = new Aluno();

Console.WriteLine("Insira as notas do 1,2 e 3 do trimestre do aluno.");
Console.Write("1 trimestre:");
aluno.N1 = double.Parse(Console.ReadLine());
Console.Write("2 trimestre:");
aluno.N2 = double.Parse(Console.ReadLine());
Console.Write("3 trimestre:");
aluno.N3 = double.Parse(Console.ReadLine());

if(aluno.NotaFinal() >= 60.0){
    Console.WriteLine("Nota final:" + aluno.NotaFinal().ToString("F2"));
    Console.WriteLine("Aprovado.");
}else{
    Console.WriteLine("Nota final:" + aluno.NotaFinal().ToString("F2"));
    Console.WriteLine("Reprovado.");
    Console.WriteLine("Faltaram " + (60.0 - aluno.NotaFinal()).ToString("F2") + " pontos.");
}
*/


/*
using testeC_;

ContaBancaria c1;
double valor;

Console.WriteLine("Insira os dados da conta:");
Console.WriteLine("Número da conta:");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Nome:");
string nome = Console.ReadLine();

Console.WriteLine("Você irá inserir um depósito inicial?(s/n)");
string confirmacao = Console.ReadLine();

if(confirmacao == "s"){
    Console.WriteLine("Insira um valor de depósito:");
    valor = double.Parse(Console.ReadLine());
    c1 = new ContaBancaria(numero, nome, valor);
}else{
    c1 = new ContaBancaria(numero, nome);
}

Console.WriteLine(c1);

Console.WriteLine("Insira um valor para depósito:");
valor = double.Parse(Console.ReadLine());
c1.deposito(valor);
Console.WriteLine(c1);

Console.WriteLine("Insira um valor para saque");
valor = double.Parse(Console.ReadLine());
c1.saque(valor);
Console.WriteLine(c1);
*/

/*
using testeC_;

int numeroQuartos;
AluguelQuarto[] quartos= new AluguelQuarto[10];

Console.Write("Insira quantas pessoas irão alugar quartos:");
numeroQuartos = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o nome,email e número de quarto das pessoas:");

for(int i = 0; i < numeroQuartos; i++){
    Console.Write("Nome:");
    string nome = Console.ReadLine();
    Console.Write("Email:");
    string email = Console.ReadLine();
    Console.Write("Número de quarto:");
    int quarto = int.Parse(Console.ReadLine());
    quartos[quarto] = new AluguelQuarto(nome, email, quarto);
}

Console.WriteLine();
Console.WriteLine("Quartos ocupados:");
for(int i = 0; i < 10; i++){
    if(quartos[i] != null){
        Console.WriteLine(quartos[i]);
    }
}
*/

/*
using System.Collections.Generic;

using testeC_;

List<Employee> Funcionarios = new List<Employee>();
Employee funcionario;

Console.Write("Insira a quantidade de funcionários que serão cadastrados:");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    Console.WriteLine();
    Console.Write("Insira o ID:");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Insira o nome:");
    string nome = Console.ReadLine();
    Console.Write("Insira o salário:");
    double salario = double.Parse(Console.ReadLine());
    funcionario = new Employee(id, nome, salario);
    Funcionarios.Add(funcionario);
}

Console.WriteLine("Insira o ID do funcionário e a porcentagem do salário dele que será aumentada.");
Console.Write("ID:");
int idd = int.Parse(Console.ReadLine());
Console.Write("Porcentagem:");
double porcentagem = double.Parse(Console.ReadLine());

Employee func = new Employee();
func = Funcionarios.Find(x => x.Id == idd);

Console.WriteLine();
if(func != null){
    func.increaseSalary(porcentagem);
    Console.WriteLine("Salário aumentado com sucesso.");
}else{
    Console.WriteLine("ID não encontrado.");
}

Console.WriteLine();
foreach (Employee item in Funcionarios)
{
    Console.WriteLine(item);
}
*/

Console.Write("Insira a quantidade de linhas de matriz:");
int M = int.Parse(Console.ReadLine());
Console.Write("Insira a quantide de colunas da matriz:");
int N = int.Parse(Console.ReadLine());

int[,] matriz = new int[M, N];

Console.WriteLine("Insira os números inteiros da matriz.");

for(int i = 0; i < M; i++){
    string[] itens = Console.ReadLine().Split(' ');
    for(int j = 0; j < N; j++){
        matriz[i, j] = int.Parse(itens[j]);
    }
}

Console.Write("Insira um número da matriz:");
int numero = int.Parse(Console.ReadLine());

for(int i = 0; i < M; i++){
    for(int j = 0; j < N; j++){
        if(matriz[i,j] == numero){
            Console.WriteLine("Posição " + i + "," + j + ":");
            if()
            Console.WriteLine("Esquerda: " + matriz[i, j-1]);
            Console.WriteLine("Direita: " + matriz[i, j+1]);
            Console.WriteLine("Acima: " + matriz[i-1, j]);
            Console.WriteLine("Abaixo: " + matriz[i+1, j-1]);
        }
    }
}
