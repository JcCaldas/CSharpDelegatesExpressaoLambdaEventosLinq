


public class Pessoa
{
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }

    public static List<Pessoa> GetPessoas()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa("João", 20),
            new Pessoa("Maria", 18),
            new Pessoa("Pedro", 25),
            new Pessoa("Carlos", 15),
            new Pessoa("Ana", 17)
        };
        return pessoas;
    }
}