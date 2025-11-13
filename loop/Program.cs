//loop for

using System.Runtime.Serialization;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
    Thread.Sleep(100); //comando para ter delay na impressão do console
}

Console.WriteLine("\n"); //Pular linha

int soma = 0;
for (int j = 1; j <= 100; j++)
{
    soma += j; //Soma o valor de j à variável soma, ex: 1+2+3+4....99+100
}

Console.WriteLine("A soma dos Números de 1 a 100 é:" + soma);

Console.WriteLine("\n"); //Pular linha


// Loop Infinito

/*for (; ;) // ;; "cria loops infinitos"
{
    Console.WriteLine("Este é um loop infinito!");
}
*/


//Loop While (enquanto)
int contador = 1;

while (contador <=5)
{
    Console.WriteLine(contador);
    contador++; //Incrementa o contador
}

Console.WriteLine("\n"); //Pular linha

//Loop do While (faça enquanto)
int novocontador = 1;

do
{
    Console.WriteLine(novocontador);
    novocontador++; //incrementa o contador
}while (novocontador <= 7);

Console.WriteLine("\n"); //Pular Linha


/*
//Loop Infinito While
while (true)
{
    Console.WriteLine("Este é um loop infinito!");
}
*/

//Loop Foreach

//Uma lista de strings
List<string> nomes = new List<string> { "Ana", "Maria", "João", "Carlos" };

//Usando o foreach para percorrer a lista
foreach (string nome in nomes)
{
    Console.WriteLine(nome); //Imprime cada nome exibindo na tela
}

Console.WriteLine("\n");

int[] numeros = { 1, 2, 3, 4, 5 };

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}