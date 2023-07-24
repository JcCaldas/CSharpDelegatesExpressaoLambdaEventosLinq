Console.WriteLine("10 - EventHander<TEventArgs>\n");

Console.WriteLine("Usando o EventHander<TEventArgs>");

var pedido = new Pedido();

//inscrever os assinantes no evento, se não inscrever antes de chamar o método, o evento fica null.
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido("email@email.com", "27999999999");


class PedidoEventArgs : EventArgs //não importa o nome da classe, desde que a herança esteja certa
{
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}

class Pedido
{
    public event EventHandler<PedidoEventArgs> OnCriarPedido; //criação do evento.

    public void CriarPedido( string email, string telefone)
    {
        Console.WriteLine("\nPedido criado");
        //Sempre verificar se o evento é null antes de chama-lo
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = telefone});
        }
    }
}

class Email
{
    public static void Enviar(object? sender, PedidoEventArgs e) //mesma assinatura do delegate EventHandler
    {
        Console.WriteLine($"\nEnviando E-mail para {e.Email}");
    }
}

class SMS
{
    public static void Enviar(object? sender, PedidoEventArgs e) //mesma assinatura do delegate EventHandler
    {
        Console.WriteLine($"\nEnviando SMS para {e.Telefone}");
    }
}
