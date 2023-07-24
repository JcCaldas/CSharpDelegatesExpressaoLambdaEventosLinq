using _11MetodosExtensao;

Console.WriteLine("11 - Métodos de Extensão\n");

string texto = "Usando métodos de extensão";

string textoInvertido = texto.InverteString(); //o método criado agora faz parte da classe string

Console.WriteLine($"Texto normal: {texto}");
Console.WriteLine($"\nTexto invertido: {textoInvertido}");