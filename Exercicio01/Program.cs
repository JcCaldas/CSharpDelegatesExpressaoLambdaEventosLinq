

Console.WriteLine("Exercício 01 - Delegates\n");
/*considere que esteja desenvolvendo um sistema que gerencia uma lista de pessoas.
 Cada pessoa possui nome e idade.
1 - Percorrer lista de pessoas e imprimir nome e idade de cada uma utilizando Delegate
2 - Filtrar a lista de pessoas, retornandoa penas aquelas que possuem idade maior que 18 anos utilizando Delegate
3 - Obter o nome e idade da pessoa mais velha da lista utilizando Delegate

 Dados: Classe Pessoa com duas propriedades Nome e Idade
Lista de pessoas: João-20, Maria-18, Pedro-25, Carlos-15, Ana-17*/

var listaPessoas = Pessoa.GetPessoas();

Console.WriteLine("Imprime nome com Delegate \"Action<Pessoa>\"\n");
Action<Pessoa> imprimirNome = p => Console.WriteLine($"Nome: {p.Nome}\tIdade: {p.Idade} anos");
listaPessoas.ForEach(imprimirNome);
/* A linha acima faz a messa função dessa chamada
foreach (Pessoa p  in listaPessoas)
{
    imprimirNome(p);
}*/

Console.WriteLine("\nFiltrar pessoas maiores de 18 anos com Delegate \"Predicate <Pessoa>\"\n");
Predicate<Pessoa> filtrarIdadeMaior18Anos = p => p.Idade > 18;
var pessoasMaiores18Anos = listaPessoas.FindAll(filtrarIdadeMaior18Anos);

//Usando Delegate Action para exibir o resultado
pessoasMaiores18Anos.ForEach(imprimirNome);

Console.WriteLine("\nObter nome e idade da pessoa mais velha da lista utilizando Delegate \"Func<Pessoa>\"\n");
Func<Pessoa, int> obterIdade = p => p.Idade;

var pessoaMaisVelha = listaPessoas.MaxBy(obterIdade); //resume os códigos comentados.
//int idadeMaxima = listaPessoas.Max(obterIdade);
//var pessoaMaisVelha = listaPessoas.Find(p => p.Idade == idadeMaxima);

Console.WriteLine($"A pessoa mais velha é {pessoaMaisVelha.Nome} com {pessoaMaisVelha.Idade} anos.");