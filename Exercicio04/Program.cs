Console.WriteLine("Exercício 04\n");

/* Imagine que você precisa criar um método que imprima na tela os números pares de uma lista de inteiros
de 1 a 20.
Para isso, você deve utilizar um delegate Action<int> que receba um número inteiro como parâmetro e
imprima na tela apenas os números pares*/

List<int> lista = new List<int>();
for  (int i = 1; i <= 20; i++)
{
    lista.Add(i);
}

Console.WriteLine("Números Pares\n");
//Define um delegate Action<int> que verifica se um número é par e imprime na tela caso seja. 
Action<int> imprimirPares = n =>
{
    if (n % 2 == 0)
    {
        Console.Write($"{n} ");
    }
};

//O método ForEach da lista de inteiros recebe o delegate como parâmetro e executa o método para cada elemento da lista.
lista.ForEach(imprimirPares);