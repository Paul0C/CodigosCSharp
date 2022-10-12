/*
Console.Write("Insira a senha:");

int senha = int.Parse(Console.ReadLine());

while(senha != 2002){
    Console.WriteLine("Senha inválida.");
    Console.Write("Insira a senha novamente:");
    senha = int.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso permitido.");
*/

/*
string[] vetorCoordenadas;
double x, y;

Console.WriteLine("Insira uma coordenada:");
vetorCoordenadas = Console.ReadLine().Split(' ');
x = double.Parse(vetorCoordenadas[0]);
y = double.Parse(vetorCoordenadas[1]);
 

while(x != 0 && y != 0){
     if(x>0 && y>0){
        Console.WriteLine("1 Quadrante.");
     }else if(x<0 && y>0){
         Console.WriteLine("2 Quadrante.");
     }else if(x<0 && y<0){
         Console.WriteLine("3 Quadrante.");
     }else{
         Console.WriteLine("4 Quadrante.");
     }
     Console.WriteLine("Insira novamente uma coordenada:");
     vetorCoordenadas = Console.ReadLine().Split(' ');
    x = double.Parse(vetorCoordenadas[0]);
    y = double.Parse(vetorCoordenadas[1]);

}
*/

/*
int combustivel, Alcool=0, Diesel=0, Gasolina=0;

Console.WriteLine("Insira 1,2,3 ou 4 para os seguintes fins:");
Console.WriteLine("1.Àlcool, 2.Gasolina, 3.Diesel, 4.Fim.");
Console.WriteLine("Com qual combustível irá abastecer?");

combustivel = int.Parse(Console.ReadLine());

while(combustivel != 4){
    if(combustivel != 1 && combustivel != 2 && combustivel != 3){
        Console.WriteLine();
        Console.WriteLine("Insira um código válido.");
        Console.WriteLine();
    }

    if(combustivel == 1){
        Alcool++;
    }else if(combustivel == 2){
        Gasolina++;
    }else if(combustivel == 3){
        Diesel++;
    }
    Console.WriteLine();
    Console.WriteLine("Com qual combustível irá abastecer?");
    Console.WriteLine("1.Àlcool, 2.Gasolina, 3.Diesel, 4.Fim.");
    combustivel = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Àlcool:" + Alcool);
Console.WriteLine("Gasolina:" + Gasolina);
Console.WriteLine("Diesel:" + Diesel);  
*/
