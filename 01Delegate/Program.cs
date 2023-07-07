using _01Delegates;

Console.WriteLine("Delegates");

Console.WriteLine("\nCalculo utilizando classe converncional");
var resultado = Calculadora.Somar(10, 40);
Console.WriteLine($"10 + 40 = {resultado}");

Console.WriteLine("\nCalculos utilizarndo Delegates");

//Declaração de Delegate
//Pode-se usar o Invoke ou não.
//Forma 1:
DelegateCalculadora somar = new DelegateCalculadora(Calculadora.Somar);
var resultado1 = somar.Invoke(10, 40);
Console.WriteLine($"\n10 + 40 = {resultado1}");

//Forma 2 - método mais simples:
DelegateCalculadora multiplicar = Calculadora.Multiplicar;
var resultado2 = multiplicar(10, 40);
Console.WriteLine($"\n10 * 40 = {resultado2}");

//Forma 3:
DelegateCalculadora subtratir = (float x, float y) => Calculadora.Subtrair(x, y);
var resultado3 = subtratir(40, 10);
Console.WriteLine($"\n40 - 10 = {resultado3}");

//Pode-se usar a mesma instância do delegate para utilizar outros métodos.
Console.WriteLine("\nDelegate na mesma instância:");
DelegateCalculadora calc = Calculadora.Multiplicar;
var resultado4 = calc(10, 40);
Console.WriteLine($"\n10 * 40 = {resultado4}");

calc = Calculadora.Subtrair;
var resultado5 = calc(10, 40);
Console.WriteLine($"\n10 - 40 = {resultado5}");

calc = Calculadora.Dividir;
var resultado6 = calc(10, 40);
Console.WriteLine($"\n10 / 40 = {resultado6}");

calc = Calculadora.Somar;
var resultado7 = calc(10, 40);
Console.WriteLine($"\n10 + 40 = {resultado7}");

public delegate float DelegateCalculadora (float x, float y); //Criação de Delegate