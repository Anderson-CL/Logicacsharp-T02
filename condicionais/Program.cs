//Condicional IF
string nome = "Joca";

if(nome == "Joca")
{
    Console.WriteLine("Olá, Joca!"); //if else sempre se usa { }
}

string texto = ""; 


if (string.IsNullOrEmpty(texto)) 
{
    Console.WriteLine("A String Está vazia.");
}

//Condicional IF/ELSE

int idade = 16;

if (idade >= 18) //Sim
{
    Console.WriteLine("Você já pode ser preso bro");
}
else //SeNão
{
    Console.WriteLine("Você ainda é só um garotinho.");
}

int numero = 2;

if (numero %2 ==0)

{
    Console.WriteLine("O numero é Par");
}
    

else

{
    Console.WriteLine("O Numero é Impar");
}

//Teste

double nota = 6.5;

if (nota >= 9.0)

{
    Console.WriteLine("Você é foda cara!");
}

else if (nota >= 7.0)

{
    Console.WriteLine("Você é fodinha, passou raspando!");
}

else if (nota >= 5.0)
{
    Console.WriteLine("Meu amigo, na proxima tu se arrasa!");
}

else if (nota >= 3.0)
{
    Console.WriteLine("Tu é Burro hein, vai estudar!");
}

else
{
    Console.WriteLine("KKKKKKKKKKKKKKK Reprovado");
}

//Condicional switch
double pontuacao = 8.5;

// Arredondando a nota para o inteiro mais proximo (match.floor arredonda para baixo)
int faixaNota = (int)Math.Floor(pontuacao);

switch (faixaNota)
{
    case 10:
        Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");
        break;
    case 9:
    case 8:
        Console.WriteLine("Você está aprovado.");
        break;
    case 7:
    case 6:
        Console.WriteLine("Você está em Recuperação.");
        break;
    case 5:
    case 4:
    case 3:
        Console.WriteLine("Você está com risco de reprovação");
        break;
    default:
        Console.WriteLine("Você foi Reprovado.");
        break;
    
}