/* Exercícios com if, else e elseif:
1.Faça um programa para verificação de estoque
Um sistema de gerenciamento de estoque precisa notificar os funcionários 
quando for hora de reabastecer um produto. 
Escreva um código que verifique a quantidade de um produto em estoque. Se a 
quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor, 
reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente.".*/



//Verificação de estoque

{

    

    {

        Console.Write("Digite a quantidade do produto em estoque: ");

        int quantidade = Convert.ToInt32(Console.ReadLine());

        if (quantidade < 5)

        {

            Console.WriteLine("Alerta: Baixo estoque. Por favor, reabasteça este produto.");

        }

        else

        {

            Console.WriteLine("Estoque suficiente.");

        }

    }

}


/*2. Faça um programa de desconto
Uma loja oferece um desconto para compras acima de um certo valor como parte 
de uma promoção de vendas. Escreva um código que determine o valor total da 
compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um 
desconto de 10% e exiba: "Desconto de 10% aplicado!".Se o valor total for R$ 
200,00 ou menos, informe: "Adicione mais itens ao carrinho para ganhar um 
desconto de 10%.". 
Exercícios com switch:*/


//Programa de desconto


{

    

    {

        Console.Write("Digite o valor total da compra: R$ ");

        double valorCompra = Convert.ToDouble(Console.ReadLine());


        if (valorCompra > 200)

        {

            double valorComDesconto = valorCompra - (valorCompra * 0.10);

            Console.WriteLine("\nDesconto de 10% aplicado!");

            Console.WriteLine($"Valor original: R$ {valorCompra:F2}");

            Console.WriteLine($"Valor com desconto: R$ {valorComDesconto:F2}");

        }

        else

        {

            Console.WriteLine("\nAdicione mais itens ao carrinho para ganhar um desconto de 10%.");

            Console.WriteLine($"Valor atual: R$ {valorCompra:F2}");

        }

    }

}



/*1.Faça um programa que determine o dia da semana
O programa deve receber um número de 1 a 7, representando um dia da semana,
e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 = 
"Segunda-feira", etc.).*/



//Dia da semana
{
   
    {
        Console.Write("Digite um número de 1 a 7 para o dia da semana: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-feira");
                break;
            case 3:
                Console.WriteLine("Terça-feira");
                break;
            case 4:
                Console.WriteLine("Quarta-feira");
                break;
            case 5:
                Console.WriteLine("Quinta-feira");
                break;
            case 6:
                Console.WriteLine("Sexta-feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Número inválido! Digite um valor entre 1 e 7.");
                break;
        }
    }
}




/*2. Faça um programa que calcule o preço final de um produto com base em um 
código de desconto
O programa deve receber um código de desconto (de 1 a 3) e aplicar o desconto 
correspondente ao preço do produto.
o Código 1: 10 % de desconto
o Código 2: 20 % de desconto
o Código 3: 30 % de desconto
o Se o código for inválido, deve mostrar uma mensagem de erro.
Exercícios com for:*/



//Solicita o preço do produto
{
  
    {
        Console.Write("Digite o preço do produto: R$ ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o código de desconto (1, 2 ou 3): ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        double desconto = 0;

        switch (codigo)
        {
            case 1:
                desconto = 0.10;
                break;
            case 2:
                desconto = 0.20;
                break;
            case 3:
                desconto = 0.30;
                break;
            default:
                Console.WriteLine("Código inválido! Nenhum desconto aplicado.");
                return;
        }

        double precoFinal = preco - (preco * desconto);

        Console.WriteLine($"\nCódigo {codigo}: Desconto de {desconto * 100}% aplicado!");
        Console.WriteLine($"Preço original: R$ {preco:F2}");
        Console.WriteLine($"Preço com desconto: R$ {precoFinal:F2}");
    }
}



/*1.Faça um programa de tabuada de multiplicação 
Crie um programa que mostre na tela as tabuadas do número 7, utilizando laço de 
repetição for.
O programa deve exibir, para cada número de 7, a multiplicação desse número 
pelos valores de 1 a 10.*/

//Tabuada de multiplicação



{
    static void Main()
    {
        Console.Write("Digite um número para ver a tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }
    }
}


//1.Número de 1 a 7 → dia da semana





{
    static void Main()
    {
        Console.Write("Digite um número de 1 a 7: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        if (dia == 1)
            Console.WriteLine("Domingo");
        else if (dia == 2)
            Console.WriteLine("Segunda-feira");
        else if (dia == 3)
            Console.WriteLine("Terça-feira");
        else if (dia == 4)
            Console.WriteLine("Quarta-feira");
        else if (dia == 5)
            Console.WriteLine("Quinta-feira");
        else if (dia == 6)
            Console.WriteLine("Sexta-feira");
        else if (dia == 7)
            Console.WriteLine("Sábado");
        else
            Console.WriteLine("Número inválido!");
    }
}


/*2. Faça um programa para calcular a média
Crie um programa que receba 10 números inteiros e calcule a média desses 
números. Utilize o laço for para ler os números e calcular a média.
Exercícios com while:*/




{
    static void Main()
    {
        int soma = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Digite o " + i + "º número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            soma += numero;
        }

        double media = soma / 10.0;
        Console.WriteLine("A média dos números digitados é: " + media);
    }
}




/*1.Faça um programa contador de visitantes
Desenvolva um código que simula a entrada X visitantes aleatoriamente no 
museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar" 
cada visitante até que a capacidade máxima seja atingida. A cada visitante 
adicional, exiba o número total de visitantes até o momento.*/



{
    static void Main()
    {
        Random rnd = new Random();
        int visitantes = 0;
        int capacidadeMaxima = 50;

        while (visitantes < capacidadeMaxima)
        {
            int novos = rnd.Next(1, 6); // 1 a 5 visitantes
            visitantes += novos;
            if (visitantes > capacidadeMaxima)
                visitantes = capacidadeMaxima;

            Console.WriteLine("Visitantes até agora: " + visitantes);
        }

        Console.WriteLine("Capacidade máxima atingida!");
    }
}



/*2. Faça um programa de sistema de login
Um sistema de login precisa verificar a autenticidade do usuário, permitindo 
múltiplas tentativas até que as credenciais corretas sejam fornecidas.
Desenvolva um código que simule um sistema de login usando um loop while. O 
usuário tem um máximo de 3 tentativas para inserir a senha correta. Se a senha 
correta ("senha123") for inserida, exiba "Login bem-sucedido!". Se o limite de 
tentativas for atingido, mostre "Conta bloqueada por excesso de tentativas."*/



{
    static void Main()
    {
        string senhaCorreta = "senha123";
        int tentativas = 0;
        bool login = false;

        while (tentativas < 3 && login == false)
        {
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();
            tentativas++;

            if (senha == senhaCorreta)
            {
                Console.WriteLine("Login bem-sucedido!");
                login = true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
            }
        }

        if (login == false)
            Console.WriteLine("Conta bloqueada por excesso de tentativas.");
    }
}