Console.WriteLine("Exercício 08\n");

/* Utilizando o método Where
Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para obter somente as
strings que contenham a letra 'a'.*/

string[] frutas = { "banana", "abacaxi", "uva", "laranja", "abacate", "Kiwi" };

//Filtrando as frutas que contém a letra 'a'
var consulta = frutas.Where(fruta => fruta.Contains('a'));
/*//Outra forma
var consulta = from fruta in frutas
               where fruta.Contains('a')
               select fruta;*/



//Exibindo as frutas que foram filtradas
Console.WriteLine("Frutas que contém a letra \"a\"");
foreach (var fruta in consulta)
{
    Console.WriteLine(fruta);
}

Console.ReadKey();