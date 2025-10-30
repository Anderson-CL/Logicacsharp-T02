//Declarando Constantes
const int valor1 = 5;
const int valor2 = 10;

//Soma
int soma = valor1 + valor2;
Console.WriteLine($"Soma : {valor1} + {valor2} = " + soma);

//Subtração
int sub = valor1 - valor2;
Console.WriteLine($"Subtração: {valor1} - {valor2} = " + sub);

//Multiplicação
int mult = valor1 * valor2;
Console.WriteLine($"multiplicação: {valor1} * {valor2} = " + mult);

//Divisão (resultado)
double div =(float) valor1 / (float) valor2;
Console.WriteLine($"Divisão: {valor1} / {valor2} = " + div);


//Resto da divisão
int restdiv = valor1 % valor2;
Console.WriteLine($"Resto da Divisão de: {valor1} / {valor2} = " + restdiv);

//Potenciação (usando Math.Pow para calcular a potência)
double potencia = Math.Pow(valor1, valor2);
Console.WriteLine($"Potenciação: {valor1} elevado a {valor2} = {potencia}");

/*Ueeeeeeeeeeeeee
 * aaaaaaaaa
 * eeeeeeeeee*/

//Exemplo 1: Sem Parênteses
int resultado1 = 3 + 5 * 2; // multiplicação tem prioridade
Console.WriteLine($"Resultado 1 (Sem parenteses): 3 + 5 * 2 = {resultado1}");

//Exemplo 1: Com Parênteses
int resultado2 = (3 + 5) * 2; // Parênteses alteram ordem
Console.WriteLine($"Resultado 2 (Com parenteses): (3 + 5) * 2 = {resultado2}");

//Exemplo 2: Sem Parênteses
int resultado3 = 8 / 4 + 3; // Divisão tem prioridade
Console.WriteLine($"Resultado 3 (Sem parenteses): 8 / 4 + 3 = {resultado3}");

//Exemplo 2: Com Parênteses
double resultado4 = 8.0 / (4 + 3); //Parenteses alteram a ordem
Console.WriteLine($"Resultado 4 (Com parenteses): 8 / 4 + 3 = {resultado4}");


