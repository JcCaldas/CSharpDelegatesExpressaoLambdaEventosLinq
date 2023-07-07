Console.WriteLine("05 - Delegate Predicate\n");

/*Otimização do código abaixo utilizando o "Delegate Predicate"
Console.WriteLine("Informa um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (VerificaPar(numero))
    Console.WriteLine($"O número {numero} é PAR");
else
    Console.WriteLine($"O número {numero} é IMPAR");

Console.ReadKey();

static bool VerificaPar(int x)
{
    if (x % 2 == 0)
        return true;
    else
        return false;
}*/

Console.WriteLine("Informa um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

Predicate<int> delegatePar = x => x % 2 == 0; //Recebe um único argumento de entrada do tipo informado e retorna um bool.

if (delegatePar(numero))
    Console.WriteLine($"O número {numero} é PAR");
else
    Console.WriteLine($"O número {numero} é IMPAR");

Console.ReadKey();