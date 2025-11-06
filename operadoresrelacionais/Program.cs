int a = 10;
int b = 5;

//Operadores Relacionais

bool maiorQ = a > b;
bool menorQ = a < b;
bool igual = a == b;
bool diferente = a != b;
bool maiorOuIgual = a >= b;
bool menorOuIgual = a <= b;

Console.WriteLine("\nOperadores Relacionais: ");
Console.WriteLine($"{a} > {b}: {maiorQ}");
Console.WriteLine($"{a} < {b}: {menorQ}");
Console.WriteLine($"{a} == {b}: {igual}");
Console.WriteLine($"{a} != {b}: {diferente}");
Console.WriteLine($"{a} >= {b}: {maiorOuIgual}");
Console.WriteLine($"{a} <= {b}: {menorOuIgual}");