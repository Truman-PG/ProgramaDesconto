//Exibe o nome do programa
Console.WriteLine("PROGRAMA DE DESCONTO");

//Criamos a variável de resposta do usuário
string resposta = "";

do
{
    //Solicita o valor do produto
    Console.WriteLine("Qual o valor do produto:");
    double valorProduto = double.Parse(Console.ReadLine());

    //Solicita o valor do desconto
    Console.WriteLine("Qual o valor de desconto: ");
    double valorDesconto = double.Parse(Console.ReadLine());

    //Comparações de variáveis com exceções
    if (valorDesconto > 50 || valorDesconto < 0)
    {
        Console.WriteLine("Desconto não pode ser maior que 50% e menor que 0%");
    }
    else if (valorDesconto > 10 && valorProduto < 100)
    {
        Console.WriteLine("Desconto não pode ser maior que 10% se o produto é menor que 100");
    }
    else if (valorDesconto > 20 && valorProduto < 200)
    {
        Console.WriteLine("Desconto não pode ser maior que 20% se o produto é menor que 200");
    }
    else
    {
        //Resultado da operação com desconto
        double resultado = valorProduto - (valorProduto * valorDesconto / 100);
        Console.WriteLine($"O produto com desconto será de {resultado}.");
    }

    //Pergunta se a pessoa quer continuar atribuindò à variável "resposta"
    Console.WriteLine("Você deseja continuar: (Escreva: S ou N)");
    resposta = Console.ReadLine();
}

//Repete o código caso a resposta seja "S" (sim)
while (resposta == "S");