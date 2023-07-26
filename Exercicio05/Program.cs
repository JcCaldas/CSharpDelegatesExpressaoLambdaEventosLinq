Console.WriteLine("Exercício 05\n");
/*
Crie um programa onde um método que receba dois números inteiros e retorne o resultado da operação
de adição ou subtração desses números, a ser definida em tempo de execução por um delegate Func<int, int,
int>.
 */

Console.WriteLine("Digite um número: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nDigite outro número: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Func<int, int, int> operacao = (x, y) =>  x + y;
Console.WriteLine($"\nA soma de {n1} e {n2} é {operacao(n1, n2)}");

operacao = (x, y) =>  x - y;
Console.WriteLine($"\nA subtracao de {n1} e {n2} é {operacao(n1, n2)}");