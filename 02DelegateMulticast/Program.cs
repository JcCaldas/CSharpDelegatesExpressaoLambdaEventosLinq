
Console.WriteLine("02 - Delegates MultiCast\n");

MeuDelegateMultiCast2 delegateMultiCast = Metodo1;
delegateMultiCast += Metodo2; //adiciona método ao delegate
delegateMultiCast += Metodo3; //adiciona método ao delegate

delegateMultiCast("Olá, multicast delegate!");

delegateMultiCast -= Metodo3; //remove método ao delegate
delegateMultiCast("O Método 3 foi removido...");


static void Metodo1 (string mensagem)
{
    Console.WriteLine("Método 1: " + mensagem);
}

static void Metodo2(string mensagem)
{
    Console.WriteLine("Método 2: " + mensagem);
}

static void Metodo3(string mensagem)
{
    Console.WriteLine("Método 3: " + mensagem);
}

public delegate string MeuDelegateMultiCast (float x, float y);
public delegate void MeuDelegateMultiCast2(string mensagem);