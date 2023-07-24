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

foreach (var item in lista)
{
    if (item % 2 == 0)
    {

    }
}