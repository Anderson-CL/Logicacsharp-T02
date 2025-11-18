// Declaração de dois vetores
using System.ComponentModel.DataAnnotations;

int[] numeros = { 7, 2, 3, 34, 5 }; //Vetores inteiros
string[] nomes = { "Ana", "João", "Maria", "Carlos" }; //Vetor de Strings

//Exibindo os elementos do vetor de numeros com loop for
Console.WriteLine("Vetor de Números (usando for): ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

//Exibindo os elementos do vetor de nomes com loop foreach
Console.WriteLine("\n Vetor de nomes (Usando foreach)");
foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

// Ordenação do vetor de Números
Array.Sort(numeros);
Console.WriteLine("\nVetor de Números Ordenados");
foreach (var n in numeros)
{
    Console.WriteLine(n);
}

int valorProcurado = 5;
int posicaoSequencial = PesquisaSequencial(numeros, valorProcurado);

    if (posicaoSequencial != -1)
{
    Console.WriteLine($"\nPesquisa Sequencial: Valor {valorProcurado} encontrado na posição {posicaoSequencial}");
}
else
{
    Console.WriteLine($"\nPesquisa Sequencial: Valor {valorProcurado} não encontrado.");
}
    static int PesquisaSequencial(int[] vetor, int valor)
{ 
    for (int i = 0; i < vetor.Length; i++)
    {
      if (vetor[i] == valor)
        return i; //Retorna o índice do valor encontrado
    }
    return -1; // Retorna -1 se não encontrar
}