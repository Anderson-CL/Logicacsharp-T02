/*1. Saudação com Nome
 
Objetivo: Declarar variáveis, usar concatenação e interpolação.
 
Descrição: Crie um script que declare uma variável para o nome de
uma pessoa e exiba uma saudação personalizada, por exemplo: "Olá,
Joao! Bem-vindo ao nosso site!".
 
Dica: Utilize tanto a concatenação (.) quanto a interpolação dentro de
uma string com aspas duplas.*/

string nome = "Zé da Manga";
Console.WriteLine($"Olá, {nome}! Bem-vindo ao nosso site!");
Console.WriteLine("Olá, " + nome + "! Bem-vindo ao nosso site!");
Console.WriteLine("\n");

/*2. Conversão de Temperatura (Celsius para Fahrenheit)
 
Objetivo: Trabalhar com cálculos matemáticos e variáveis.
 
Descrição: Crie um script que converta uma temperatura em Celsius
para Fahrenheit. A fórmula para conversão é:
F=(C×2)+32
 
Dica: Declare uma constante para armazenar o valor 9/5 e faça o
cálculo com a variavel fornecida.*/

const double fatorConversao = 9.0 / 5.0;
double celsius = 9.0;
double fahrenheit = (celsius * fatorConversao) + 32;
Console.WriteLine("Temperatura em Celsius: " + celsius);
Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);

/*3. Impressão de Dados do Usuário
Objetivo: Concatenar e interpolar dados.
Descrição: Crie um script que solicite ao usuário seu nome, idade e
cidade e depois mostre uma mensagem com essas informações.
Exemplo: "Meu nome e Joao, tenho 25 anos e moro em Sao Paulo".
Dica: Use tanto concatenação quanto interpolação.*/

Console.Write("Digite seu nome: ");
nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Digite sua cidade: ");
string cidade = Console.ReadLine();


string mensagemInterpolada = $"Meu nome é {nome}, tenho {idade} anos e moro em {cidade}.";

Console.WriteLine(mensagemInterpolada);

Console.WriteLine("\n");
/*4. Empréstimo Bancário
 
Objetivo: Calculos financeiros e declaraçao de variáveis.
 
 
Descrição: Crie um script que calcule o valor de uma parcela de um
empréstimo, dado o valor total do empréstimo, a taxa de juros e o
número de parcelas. Exemplo de fórmula:
Valor do Empréstimox(1+Taxa de Juros)
Numero de Parcelas
 
Dica: Utilize variáveis para o valor do empréstimo, a taxa de juros e o
número de parcelas.*/

double valorEmprestimo = 10000.0;
double taxaJuros = 0.05;
int numeroParcelas = 12;
double valorParcela = (valorEmprestimo * (1 + taxaJuros)) / numeroParcelas;

/*5.Conversor de Moeda
 
Objetivo: Trabalhar com variáveis, operadores e arredondamento.
 
Descriçao: Crie um script que converta uma quantia em reais para
dolares, com base em uma taxa de câmbio fornecida. Mostre o valor
convertido com 2 casas decimais.
 
Dica: Use round() para arredondar o valor para 2 casas decimais.*/

double valorReais = 1500.0;
double taxaCambio = 0.20;
double valorDolares = Math.Round(valorReais * taxaCambio, 2);
Console.WriteLine("Valor em Dolares: $" + valorDolares);
Console.WriteLine("Valor da Parcela: $" + valorParcela);
Console.WriteLine("Valor da Parcela: $" + Math.Round(valorParcela, 2));

/*6. Calculadora de Desconto
 
Objetivo: Cálculos matemáticos e uso de variáveis.
 
Descriçao: Crie um script que calcule o valor do desconto de um
produto, dado o preço original e a porcentagem de desconto. Exemplo
de fórmula:
 
Preço Original - (Preço Original x Desconto)
100
 
Dica: Use variaveis para armazenar o preço e a porcentagem do
desconto e calcule o valor final.*/

double precoOriginal = 200.0;
double porcentagemDesconto = 15.0;
double valorDesconto = precoOriginal * (porcentagemDesconto / 100);