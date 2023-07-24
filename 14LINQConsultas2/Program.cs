using _14LINQConsultas2;

Console.WriteLine("14 - Consulta LINQ parte 2\n");

var listaProdutos = Produto.GetProdutos();

//First
Console.WriteLine("- First - Localizar o primeiro elemento");

var primeiroProduto = listaProdutos.First();
//Atentar para as exceções
//ArgumetNullExceptio = Se a lista for nula
//InvalidOperationException = Se a lista for vazia

Console.WriteLine($"Primeiro Produto: {primeiroProduto.Nome} \tPreço: {primeiroProduto.Preco:C2}");

//First com critério
Console.WriteLine("\n- First - Localizar o primeiro elemento usando um critério de Nome");
//Caso não encontre, será lançada uma exceção, por isso a importância de colocar em um bloco "try catch"

try
{
var primeiraOcorrenciaComNome = listaProdutos.First(item => item.Nome == "Cadeira");

Console.WriteLine($"Primeira Ocorrência: {primeiraOcorrenciaComNome.Nome} \tPreço: {primeiraOcorrenciaComNome.Preco:C2}");

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);

}


//FirstOrDefault
Console.WriteLine("\n- FirstOrDefault - Localiza o primeiro elemento usando um critério de Nome");
var primeiraOcorrenciaComNome2 = listaProdutos.FirstOrDefault(item => item.Nome == "Cadeira");

//FirstOrDefault não lança exceção, ele retorna "null" caso não encontre, então é importante verificar se o retorno é "null"
if (primeiraOcorrenciaComNome2 != null)
    Console.WriteLine($"Primeira Ocorrência: {primeiraOcorrenciaComNome2.Nome} \tPreço: {primeiraOcorrenciaComNome2.Preco:C2}");
else
    Console.WriteLine("## Nenhum elemento foi encontrado segundo o critério ##");



//Last
//Funcionamento similar ao First, porém ele retorna o último elemento
Console.WriteLine("\n- Last - Retorna o último elemento da lista");
var ultimoElemento = listaProdutos.Last();
//Atentar para as exceções
//ArgumetNullExceptio = Se a lista for nula
//InvalidOperationException = Se a lista for vazia

Console.WriteLine($"Último elemento: {ultimoElemento.Nome} \tPreço: {ultimoElemento.Preco}");

//Last com critério
Console.WriteLine("\n- Last - Retorna o último elemento da lista com o critério definido");
//Caso não encontre, será lançada uma exceção, por isso a importância de colocar em um bloco "try catch"

try
{

    var ultimoElementoComCriterioNome = listaProdutos.Last(item => item.Nome == "Cadeira");
    Console.WriteLine($"Último elemento com critério nome: {ultimoElementoComCriterioNome.Nome} \tPreço: {ultimoElementoComCriterioNome.Preco:C2}");

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);

}

//LastOrDefault
//Funcionamento similar ao FirstOrDefault, porém retornando o último elemento
Console.WriteLine("\n- LastOrDefault - Localiza o último elemento com o critério Nome");
var ultimaOcorrenciaComNome2 = listaProdutos.LastOrDefault(item => item.Nome == "Cadeira");

//LastOrDefault não lança exceção, ele retorna "null" caso não encontre, então é importante verificar se o retorno é "null"
if (ultimaOcorrenciaComNome2 != null)
    Console.WriteLine($"Primeira Ocorrência: {ultimaOcorrenciaComNome2.Nome} \tPreço: {ultimaOcorrenciaComNome2.Preco:C2}");
else
    Console.WriteLine("## Nenhum elemento foi encontrado segundo o critério ##");

//Single
//Retorna o único elemento que atende uma condição e lança uma exceção se nenhum for encontrado. Também lança uma exceção se houver mais de um com o critério
//Por isso a importância de utilizar o bloco "try catch"

Console.WriteLine("\n- Single - Localiza o único elemento da sequência usando o critério nome");
try
{
    var unicoProduto = listaProdutos.Single(item => item.Nome == "Cadeira");
    Console.WriteLine($"Elemento: {unicoProduto.Nome} \tPreço: {unicoProduto.Preco:C2}");
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);

}

//SingleOrDefault
//Retorna o único elemento que atende uma condição e retorna um "null" se nenhum for encontrado. Também lança uma exceção se houver mais de um com o critério
Console.WriteLine("\n- SingleOrDefault - Localiza o único elemento da sequência usando o critério nome");

//importante colocar no bloco "try catch" pois ele lança uma exceção se houver mais de um elemento com o critério definido
try
{

    var unicoProduto2 = listaProdutos.SingleOrDefault(item => item.Nome == "Cadeira");
    //SingleOrDefault não lança exceção, ele retorna "null" caso não encontre, então é importante verificar se o retorno é "null"
    if(unicoProduto2 != null)
        Console.WriteLine($"Produto: {unicoProduto2.Nome} \tPreço: {unicoProduto2.Preco:C2}");
    else
        Console.WriteLine("## O Produto não existe ##");
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);

}


