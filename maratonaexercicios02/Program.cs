/*1. Faça um programa para verificação de estoque
 
Um sistema de gerenciamento de estoque precisa notificar os funcionários
quando for hora de reabastecer um produto.
Escreva um código que verifique a quantidade de um produto em estoque. Se a
quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor,
reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente.". */

Console.Write("Quantos Produtos tem em estoque? ");
int produto = int.Parse(Console.ReadLine());

if (produto <= 5)
{
    Console.WriteLine(" Alerta: baixo estoque. Por favor, reabasteça este produto");

}

else
{
    Console.WriteLine("Estoque suficiente.");
}

Console.WriteLine("\n");

/*2.Faça um programa de desconto
 
Uma loja oferece um desconto para compras acima de um certo valor como parte
de uma promoção de vendas. Escreva um código que determine o valor total da
compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um
desconto de 10% e exiba: "Desconto de 10% aplicado!".Se o valor total for R$
200,00 ou menos, informe: "Adicione mais itens ao carrinho para ganhar um
desconto de 10%.". */

int valor = 200;

if (valor >= 200)
{
    Console.WriteLine("Desconto de 10% Aplicado");
}

else //if (valor <= 200)
{
    Console.WriteLine("Adicione Mais itens ao carrinho para ganhar um desconto de 10%");
}

Console.WriteLine("\n");

/*Faça um programa que determine o dia da semana

O programa deve receber um número de 1 a 7, representando um dia da semana,
e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 =
"Segunda-feira", etc.). */

int semana = 6;

switch (semana)
{

    case 1:
        Console.WriteLine("Domingo");
        break;

    case 2:
        Console.WriteLine("Segunda Feira");
        break;

    case 3:
        Console.WriteLine("Terça Feira");
        break;

    case 4:
        Console.WriteLine("Quarta Feira");
        break;

    case 5:
        Console.WriteLine("Quinta Feira");
        break;

    case 6:
        Console.WriteLine("Sexta Feira");
        break;

    case 7:
        Console.WriteLine("Sabado");
        break;

}

Console.WriteLine("\n");

/*
2.Faça um programa que calcule o preço final de um produto com base em um
código de desconto

O programa deve receber um código de desconto (de 1 a 3) e aplicar o desconto
correspondente ao preço do produto.
o Código 1: 10 % de desconto
o Código 2: 20 % de desconto
o Código 3: 30 % de desconto
o Se o código for inválido, deve mostrar uma mensagem de erro.*/

int desconto = 1;

switch (desconto)
{
    case 1:
        Console.WriteLine("10 % De desconto Aplicado");
        break;
    case 2:
        Console.WriteLine("20% De Desconto Aplicado");
        break;
    case 3:
        Console.WriteLine("30% De Desconto Aplicado");
        break;
}

Console.WriteLine("\n");

/*1. Faça um programa de tabuada de multiplicação
 
Crie um programa que mostre na tela as tabuadas do número 7, utilizando laço de
repetição for.
O programa deve exibir, para cada número de 7, a multiplicação desse número
pelos valores de 1 a 10.*/

int numero = 7;

Console.WriteLine($"Tabuada do {numero}:");
for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");

    Console.WriteLine("Teste: " + multi);

Console.WriteLine("\n");

/* 2.Faça um programa para calcular a média
 
Crie um programa que receba 10 números inteiros e calcule a média desses
números. Utilize o laço for para ler os números e calcular a média.*/

/* 1. Faça um programa contador de visitantes
Desenvolva um código que simula a entrada X visitantes aleatoriamente no
museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar"
cada visitante até que a capacidade máxima seja atingida. A cada visitante
adicional, exiba o número total de visitantes até o momento */

int contador = 1;

while (contador <= 50)
{
    Console.WriteLine(contador);
    contador++;
}

Console.WriteLine("\n");

/*2. Faça um programa de sistema de login
Um sistema de login precisa verificar a autenticidade do usuário, permitindo
múltiplas tentativas até que as credenciais corretas sejam fornecidas.
Desenvolva um código que simule um sistema de login usando um loop while. O
usuário tem um máximo de 3 tentativas para inserir a senha correta. Se a senha
correta ("senha123") for inserida, exiba "Login bem-sucedido!". Se o limite de
tentativas for atingido, mostre "Conta bloqueada por excesso de tentativas.". */
