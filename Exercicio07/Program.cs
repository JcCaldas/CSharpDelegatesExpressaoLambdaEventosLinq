Console.WriteLine("Exercício 07\n");
/*Crie um método de extensão para a classe List<int> na linguagem C# que, dado uma lista de inteiros,
retorne a soma de todos os elementos da lista que são ímpares.
Em seguida, crie um programa que instancie uma lista de inteiros com alguns números ímpares e alguns
números pares e use o método de extensão criado para obter a soma dos números ímpares da lista.*/

List<int> lista = new List<int>()
{
    1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22
};

Console.WriteLine($"A soma dos impares é {lista.SomaImpares()}");

Console.ReadKey();

public static class ListExtensions
{
    public static int SomaImpares(this List<int> lista)
    {
        int somaImpar = 0;
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i] % 2 == 0)
                continue;
            else
                somaImpar += lista[i];
        }
        return somaImpar;
    }
}