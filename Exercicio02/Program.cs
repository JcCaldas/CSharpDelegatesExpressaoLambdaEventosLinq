Console.WriteLine("Exercício 02\n");
/*Implemente um programa que use delegates para somar dois números inteiros. O programa deve seguir
as seguintes especificações:

a-Defina um delegate chamado OperacaoMatematica que recebe dois inteiros como parâmetros e retorna
um inteiro.

b-Defina um método que implementam a operação de soma: que recebe os dois inteiros como parâmetros

c-Crie um objeto delegate do tipo OperacaoMatematica e atribua a ele ao método definido.

d-Chame o delegate passando os parâmetros necessários e exiba o resultado da operação na tela.

Dica: Utilize o método Invoke do delegate para invocar a operação matemática.*/

OperacaoMatematica somaNumeros = Soma;
Console.WriteLine("Digite o primeiro número:");
var n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
var n2 = Convert.ToInt32(Console.ReadLine());


var resultado = somaNumeros.Invoke(n1, n2);

Console.WriteLine($"{n1} + {n2} = {resultado}");

Console.ReadKey();

static int Soma (int a, int b)
{
    return a + b;
}

public delegate int OperacaoMatematica (int x, int y);