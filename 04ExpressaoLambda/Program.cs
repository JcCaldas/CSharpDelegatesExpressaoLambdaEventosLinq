Console.WriteLine("04 - Expressão Lambda");

List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos");

string resultado = nomes.Find(nome => nome.Equals("Paulo")); //parâmetro e expressão ou bloco de instrução.

Console.WriteLine(resultado);