/*
int numero;

Console.WriteLine("Insira um número inteiro para verificar se ele é negativo ou não:");

numero = int.Parse(Console.ReadLine());
if(numero < 0){
    Console.WriteLine("Negativo");
}else{
    Console.WriteLine("Não negativo");
}
*/

/*
int numero;

Console.WriteLine("Insira um número inteiro para verificar se ele é par ou ímpar:");

numero = int.Parse(Console.ReadLine());
if(numero % 2 == 0){
    Console.WriteLine("Par");
}else{
    Console.WriteLine("Ímpar");
}
*/

/*
int A, B;

Console.WriteLine("Insira um número A e B  para verificar se eles são múltiplos:");

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());

if(A % B == 0 || B % A == 0){
    Console.WriteLine("São múltiplos.");
}else{
    Console.WriteLine("Não são múltiplos.");
}
*/

/*
int duracao, horaInicial, horaFinal;

Console.WriteLine("Insira a hora inicial e a final do jogo,para se obter a duração total:");

horaInicial = int.Parse(Console.ReadLine());
horaFinal = int.Parse(Console.ReadLine());

if(horaInicial > horaFinal){
    duracao = (24 - horaInicial) + horaFinal;
    Console.WriteLine($"O jogo durou {duracao} horas(s)");
}
else if(horaInicial < horaFinal){
    duracao = horaFinal - horaInicial;
    Console.WriteLine($"O jogo durou {duracao} hora(s)");
}else{
    Console.WriteLine($"O jogo durou 24 horas(s)");
}
*/

/*
double total;
int codigo, quantidade;
string[] vetor;

Console.WriteLine("Insira o código e a quantidade do produto consumido para receber o valor da conta a pagar.");

vetor = Console.ReadLine().Split(' ');
codigo = int.Parse(vetor[0]);
quantidade = int.Parse(vetor[1]);

if(codigo == 1){
    total = (quantidade * 1.0) * 4.00;
}else if(codigo == 2){
    total = (quantidade * 1.0) * 4.50;
}else if(codigo == 3){
    total = (quantidade * 1.0) * 5.00;
}else if(codigo == 4){
    total = (quantidade * 1.0) * 2.00;
}else {
    total = (quantidade * 1.0) * 1.50;
}

Console.WriteLine("O valor a pagar é ${0}.", total.ToString("F2"));
*/

/*
double valor;

Console.WriteLine("Insira um valor e será dito em qual destes intervalos ele se encontra ([0,25], (25,50], (50,75], (75,100])");

valor = double.Parse(Console.ReadLine());

if(valor >= 0 && valor <= 25){
    Console.WriteLine("Intervalo [0,25]");
}else if(valor >= 25 && valor <= 50){
    Console.WriteLine("Intervalo [25,50]");
}else if(valor >= 50 && valor <= 75){
    Console.WriteLine("Intervalo [50,75]");
}else if(valor >= 75 && valor <= 100){
    Console.WriteLine("Intervalo [75,100]");
}else{
     Console.WriteLine("Fora de intervalo.");
}
*/

/*
string[] vetorCoordenadas;
double x, y;

Console.WriteLine("Insira as coordenadas de um plano cartesiano para saber em qual quadrante a coordenada está:");

vetorCoordenadas = Console.ReadLine().Split(' ');
x = double.Parse(vetorCoordenadas[0]);
y = double.Parse(vetorCoordenadas[1]);

if(x == 0.0 && y == 0.0){
    Console.WriteLine("O ponto está localizado na origem.");
}else if(x > 0 && y > 0){
    Console.WriteLine("O ponto está localizado no primeiro quadrante.");
}else if(x < 0 && y > 0){
    Console.WriteLine("O ponto está localizado no segundo quadrante.");
}else if(x < 0 && y < 0){
    Console.WriteLine("O ponto está localizado no terceiro quadrante.");
}else{
    Console.WriteLine("O ponto está localizado no quarto quadrante.");
}
*/

/*
double imposto, salario;

Console.WriteLine("Insira o salário para obter a quantia de imposto a pagar.");
salario = double.Parse(Console.ReadLine());

if(salario <= 2000){
    Console.WriteLine("Imposto isento.");
}else if (salario <= 3000){
    imposto = salario * 0.08;
    Console.WriteLine($"Total de imposto a pagar R${imposto:F2}.");
}else if (salario <= 4500){
    imposto = (0.08 * 1000) + 0.18 * (salario - 3000);
    Console.WriteLine($"Total de imposto a pagar R${imposto:F2}.");
}else{
    imposto = (0.18 * 1500) + 0.28 * (salario - 4500);
    Console.WriteLine($"Total de imposto a pagar R${imposto:F2}.");
}*/