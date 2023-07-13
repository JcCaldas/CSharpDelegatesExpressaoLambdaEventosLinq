Console.WriteLine("08 - Eventos\n");

Console.WriteLine("Usando o evento OnCriarPedido");

var pedido = new Pedido();

//inscrever os assinantes no evento, se não inscrever antes de chamar o método, o evento fica null.
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();


//criar o delegate para o evento
delegate void PedidoEventoHandler(); //retorno do delegate similar ao método que ele representa.

class Pedido
{
    public event PedidoEventoHandler? OnCriarPedido; //criação do evento.

    public void CriarPedido()
    {
        Console.WriteLine("\nPedido criado");
        //Sempre verificar se o evento é null antes de chama-lo
        if (OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}

class Email
{
    public static void Enviar()
    {
        Console.WriteLine("\nEnviando E-mail");
    }
}

class SMS
{
    public static void Enviar()
    {
        Console.WriteLine("\nEnviando SMS");
    }
}
