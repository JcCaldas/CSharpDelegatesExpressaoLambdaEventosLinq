Console.WriteLine("12 - LINQ parte 1\n");

List<string> nomes = new List<string>()
{
    "Ana", "Maria", "Pedro", "Lair", "Hugo"
};

Console.WriteLine("Consulta com Query Syntax ou Sintaxe de Consulta:");

var resultado = from m in nomes //"de" elemento "em" nome da lista
                where m.Contains('o') //"onde" separa todos os elementos que contém a letra "o"
                select m; //"seleciona" todos os elementos que conteém o critério definido

//A consulta só será executada quando houver a iteração. A variável não armazena a consulta, somente a expressão
//Resultado sempre será um IEnumereable, ou seja somente pode iterar e exibir, não podendo alterar

//Exibir
Console.WriteLine("Exibindo nomes que contem o filtro definido:\n");
foreach (var m in resultado)
{
    Console.WriteLine($"Nome: {m}");
}

Console.WriteLine("\nConsulta com Method Syntax ou Sintaxe de Método:");

var resultado2 = nomes.Where(m => m.Contains('a'));//nome da lista."onde"

//A consulta só será executada quando houver a iteração. A variável não armazena a consulta, somente a expressão
//Resultado sempre será um IEnumereable, ou seja somente pode iterar e exibir, não podendo alterar

//Exibir
Console.WriteLine("Exibindo nomes que contem o filtro definido:\n");
foreach (var m in resultado2)
{
    Console.WriteLine($"Nome: {m}");
}
