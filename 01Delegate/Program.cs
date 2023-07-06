using _01Delegates;

Console.WriteLine("Delegates");

Console.WriteLine("\nCalculo utilizando classe converncional");
var resultado = Calculadora.Somar(10, 40);
Console.WriteLine($"10 + 40 = {resultado}");

Console.WriteLine("\nCalculos utilizarndo Delegates");

//Declaração de Delegate

//Forma 1:
DelegateCalculadora somar = new DelegateCalculadora(Calculadora.Somar);
var resultado1 = somar.Invoke(10, 40);
Console.WriteLine($"\n10 + 40 = {resultado1}");

//Forma 2:
DelegateCalculadora multiplicar = Calculadora.Multiplicar;
var resultado2 = multiplicar.Invoke(10, 40);
Console.WriteLine($"\n10 * 40 = {resultado2}");

//Forma 3:
DelegateCalculadora subtratir = (float x, float y) => Calculadora.Subtrair(x, y);
var resultado3 = subtratir.Invoke(40, 10);
Console.WriteLine($"\n40 - 10 = {resultado3}");

public delegate float DelegateCalculadora (float x, float y); //Criação de Delegate