
using Calculadora;

Console.WriteLine("__________Calculadora__________");

int option = 0;
Operacoes operacoes = new Operacoes();

do 
{ 
    Console.Write("1: Soma\n2: Subtração \n3: Multiplicação \n4: Divisão \nEscolha uma operação:");
    option = int.Parse(Console.ReadLine()); 
    Console.Clear();
}while (option < 0 || option > 4);


Console.Write("Digite o Primeiro Numero:");
int num = int.Parse(Console.ReadLine());

Console.Write("Digite o Primeiro Numero:");
int num2 = int.Parse(Console.ReadLine());

switch(option){

    case 1:
        Console.WriteLine("Soma");
        Console.WriteLine("Resultado: "+operacoes.Somar(num, num2));
    break;
    case 2:
        Console.WriteLine("Subtração");
        Console.WriteLine("Resultado: "+operacoes.Subtrair(num, num2));
    break;
    case 3:
        Console.WriteLine("Multiplicção");
        Console.WriteLine("Resultado: "+operacoes.Multiplicar(num, num2));
    break;
    case 4:
        Console.WriteLine("Divisão");
        Console.WriteLine("Resultado: "+operacoes.Dividir(num, num2));
    break;
}


