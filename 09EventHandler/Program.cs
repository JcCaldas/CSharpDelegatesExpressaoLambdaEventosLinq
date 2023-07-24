Console.WriteLine("09 - EventHandler\n");

Console.WriteLine("Usando o EventHandler");

var pedido = new Pedido();

//inscrever os assinantes no evento, se não inscrever antes de chamar o método, o evento fica null.
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();


//Não precisa criar o delegate

class Pedido
{
    public event EventHandler? OnCriarPedido; //criação do evento.

    public void CriarPedido()
    {
        Console.WriteLine("\nPedido criado");
        //Sempre verificar se o evento é null antes de chama-lo
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, EventArgs.Empty);
        }
    }
}

class Email
{
    public static void Enviar(object? sender, EventArgs e) //mesma assinatura do delegate EventHandler
    {
        Console.WriteLine("\nEnviando E-mail");
    }
}

class SMS
{
    public static void Enviar(object? sender, EventArgs e) //mesma assinatura do delegate EventHandler
    {
        Console.WriteLine("\nEnviando SMS");
    }
}
