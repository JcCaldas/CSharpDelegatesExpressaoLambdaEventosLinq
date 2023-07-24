using _13LINQConsultas1;

Console.WriteLine("13 - Consulta LINQ parte 1\n");

//Fonte de dados
var listaProdutos = Produto.GetProdutos();

//Consultas LINQ
Console.WriteLine("Produtos eletrônicos:");

var produtosEletronicos = listaProdutos.Where(item => item.Categoria == "Eletrônicos");

Exibr(produtosEletronicos);

//Filtrando com duas condições
Console.WriteLine("\nProdutos mais caros com estoque superior a 5:");

var produtosCarosComEstoque = listaProdutos.Where(item => item.Preco >= 2000 && item.Estoque >= 5);

Exibr(produtosCarosComEstoque);

//Filtrando com ordenação
Console.WriteLine("\nLista de produtos com estoque mínimo (<10) ordenados por nome:");

int minimo = 10;

//Dessa forma facilita a leitura
var produtosEstoqueMinimo = listaProdutos
                            .Where(item => item.Estoque < minimo)
                            .OrderBy(item => item.Nome);

Exibr(produtosEstoqueMinimo);

/* ou
var produtosEstoqueMinimo = listaProdutos.Where(item => item.Estoque < minimo).ToList();
var produtosOrdenados = produtosEstoqueMinimo.OrderBy(item => item.Nome);
Exibr(produtosOrdenados);
*/

//Ordenando por mais de um critério
Console.WriteLine("\nProdutos ordenados por categoria e nome:");
var produtosOrdenadosPorCartegoriaENome = listaProdutos
                                          .OrderBy(item => item.Categoria) //Ordenar por...
                                          .ThenBy(item => item.Nome); //Também por...

//Logica criada apenas para melhorar a visualização
string? categoriaAnterior = "";
foreach (var item in produtosOrdenadosPorCartegoriaENome)
{
    if (item.Categoria != categoriaAnterior)
    {
        Console.WriteLine($"\n\t{item.Categoria}");
        categoriaAnterior = item.Categoria;
    }
    Console.WriteLine($"\t\t{item.Nome}");
}


//Cria uma lista de strings com nomes dos produtos
Console.WriteLine("\nLista dos nomes dos produtos ordenados:");

var nomesDosProdutos = listaProdutos
                        .Select(item => item.Nome) //transforma a lista de produtos em um IEnumerable do tipo string
                        .OrderBy(nome => nome); //ordena os nomes

foreach (var item in nomesDosProdutos)
{
    Console.WriteLine($"{item}");
}

//Filtrando por preço, ordenando por nome e criando um tipo anônimo
Console.WriteLine("\nProdutos com valor menor que R$500 com aumento de 10% ordenados por nome");

var resultado = listaProdutos.Where(item => item.Preco < 500)
                             .OrderBy(item => item.Nome)
                             .Select(item => new
                             {
                                 NomeDoProduto = item.Nome.ToUpper(),
                                 NovoPreco = item.Preco * 1.1
                             }); //cria um tipo anônimo em tempo de compliação, substitundo os dados anterior pelos novos dados.

foreach (var item in resultado)
{
    Console.WriteLine($"Nome do produto: {item.NomeDoProduto}\tNovo preço: {item.NovoPreco:C2}");
}

//Filtrando e ordenando por preço e aplicando um desconto de 20%
Console.WriteLine("\nProdutos com valor maior que R$2000 com desconto de 20% ordenados por preço");

var resultado1 = listaProdutos.Where(item => item.Preco > 2000)
    .OrderBy(item => item.Preco)
    .Select(item => new
    {
        NomeDoProduto = item.Nome.ToUpper(),
        PrecoAnterior = item.Preco,
        PrecoComDesconto = item.Preco * .8
    });

foreach (var item in resultado1)
{
    Console.WriteLine($"Nome do produto: {item.NomeDoProduto}\tPreço anterior: {item.PrecoAnterior:C@}\tNovo preço: {item.PrecoComDesconto:C2}");
}


//Realizando cálculos de somatória, média e contagem
//Média
Console.WriteLine("\nValor médio dos produtos eletrônicos");

string categoria = "Eletrônicos";
double mediaPrecosEletronicos = listaProdutos.Where(item => item.Categoria == categoria)
                                             .Average(item => item.Preco);//Média

Console.WriteLine($"Média de valores da categoria \"Eletrônicos\": {mediaPrecosEletronicos:C2}");

//Somatória
Console.WriteLine("\nValor total dos produtos em estoque");

double valorTotalEstoque = listaProdutos.Where(item => item.Estoque > 0)
                                        .Sum(item => item.Preco * item.Estoque);

Console.WriteLine($"Valor total em estoque: {valorTotalEstoque:C2}");

//Contagem
Console.WriteLine("\nQuantidade de produtos com estoque mínimo (<10)");
int estoqueMinimo = 10;
int produtosEstoqueBaixo = listaProdutos.Where(item => item.Estoque < estoqueMinimo).Count();

//complementação
var nomeProdutosEstoqueBaixo = listaProdutos.Where(item => item.Estoque < estoqueMinimo)
                                            .OrderBy(item => item.Nome);


Console.WriteLine($"Quantidade de produtos com o estoque mínimo: {produtosEstoqueBaixo}\n");

foreach (var item in nomeProdutosEstoqueBaixo)
{
    Console.WriteLine($"Produto: {item.Nome}\tEstoque:{item.Estoque}");
}




static void Exibr(IEnumerable<Produto> listaProdutos)
{
    foreach (var item in listaProdutos)
    {
        Console.WriteLine($"{item.Nome} \t{item.Preco:C2} \tEstoque: {item.Estoque}");//Na expressão a letra "C" é o especificador de formato para moeda, e o número "2" é o número de casas decimais a serem exibidas.
    }
}