Console.WriteLine("07 - Delegate Func\n");

/*Otimização do código abaixo utilizando o "Delegate Func":

Console.WriteLine("Digite um número:");
double numero = Convert.ToDouble(Console.ReadLine());

var resultado = CalculaRaiz(numero);

Console.WriteLine($"A raiz quadade de {numero} é: {resultado}");

static double CalculaRaiz (double numero)
{
    return Math.Sqrt(numero);
}*/


Console.WriteLine("Digite um número:");
double numero = Convert.ToDouble(Console.ReadLine());

Func<double, double> raizQuadrada = x => Math.Sqrt(x);

var resultado = raizQuadrada(numero);

Console.WriteLine($"A raiz quadade de {numero} é: {resultado}");
