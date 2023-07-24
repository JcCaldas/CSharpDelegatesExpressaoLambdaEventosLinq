using _15LINQConsultas3;

Console.WriteLine("15 - Consulta LINQ parte 3\n");

var listaProdutos = Produto.GetProdutos();

Console.WriteLine("Agrupando por categoria");

var produtosPorCategoria = listaProdutos
                            .GroupBy(p => p.Categoria) //agrupa pela categoria
                            .OrderBy(c => c.Key) //ordena pela chave (nesse caso a categoria, que foi a chave definida no agrupamento)
                            .Select(g => new
                            {
                                Categoria = g.Key,
                                Produtos = g.OrderBy(p => p.Nome)
                                            .Select(p => new
                                               {
                                                   Nome = p.Nome,
                                                   Preco = p.Preco,
                                                   Estoque = p.Estoque
                                               })
                            });

foreach (var grupo in produtosPorCategoria)
{
    Console.WriteLine($"\n{grupo.Categoria}"); //Exibe o nome da chave usada para agrupar, nesse caso a categoria, pois foi definido que a chave recebe "categoria"

    foreach (var item in grupo.Produtos) //Dentro de grupo, foi criado uma coleção de produtos
    {
        Console.WriteLine($"Produto: {item.Nome} \tPreço: {item.Preco:C2} \tEstoque: {item.Estoque}");
    }
}