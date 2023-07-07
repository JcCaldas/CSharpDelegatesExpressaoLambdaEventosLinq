using System.Threading.Channels;

Console.WriteLine("06 - Delegate Action");

/*Otimização do código abaixo utilizando o "Delegate Action":
Console.WriteLine("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

Duplicar(numero);

static void Duplicar (int num)
{
    Console.WriteLine(num * 2);
}
*/

Console.WriteLine("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

Action<int> duplicar = x => Console.WriteLine(x * 2); //não retorna nenhum valor (void) e pode receber de um a 16 argumentos do tipo definido, separados por vírgula.

duplicar(numero);

