Console.WriteLine("Exercício 03\n");
/*Implemente um programa em C# que use multicast delegates para exibir uma mensagem de boas-vindas
ao usuário. O programa deve seguir as seguintes especificações:

a-) Defina um multicast delegate chamado MensagemBoasVindas que não recebe parâmetros e não retorna
nenhum valor.

b-) Defina duas funções que exibem uma mensagem de boas-vindas: uma em português e outra em inglês.

c-) Crie um objeto delegate do tipo MensagemBoasVindas e adicione as duas funções criadas a ele usando o
operador +=.

d-) Chame o delegate para executar as duas funções e exibir as mensagens de boas-vindas.*/

MensagemBoasVindas mensagem = BoasVindasPort;
mensagem += BoasVindasIngl;
mensagem();


Console.ReadKey();

static void BoasVindasPort()
{
    Console.WriteLine("Bem vindo!");
}

static void BoasVindasIngl()
{
    Console.WriteLine("Welcome!");
}

delegate void MensagemBoasVindas();