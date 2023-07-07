Console.WriteLine("03 - Métodos Anônimos\n");

//exemplo1
Imprimir impr = delegate (int num) //Declarar o método junto ao delegate
{
    Console.WriteLine($"Método Anônumo: {num}"); //O que o método vai fazer
};

impr(120);
impr(200);

Console.WriteLine();
//exemplo2
List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos");

//string resultado = nomes.Find(VerificaNomesNaLista);
string resultado = nomes.Find(delegate (string nome)
{
    Console.WriteLine($"Consultaome nome na lista: {nome}");
    return nome.Equals("Paulo");
});

Console.WriteLine(resultado);

Console.ReadKey();

//static bool VerificaNomesNaLista(string nome)
//{
//    Console.WriteLine($"Consultaome nome na lista: {nome}");
//    return nome.Equals("Paulo");
//}


public delegate void Imprimir(int valor);
public delegate bool VerificaNomes(string nome);