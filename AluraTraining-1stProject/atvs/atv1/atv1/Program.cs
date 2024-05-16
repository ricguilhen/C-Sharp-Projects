void operacoes()
{
    float n1 = 5;
    float n2 = 3;
    Console.WriteLine($"n1 = {n1}, n2 = {n2}");

    float soma = n1 + n2;
    float subtracao = n1 - n2;
    float multiplicacao = n1 * n2;
    float divisao = n1 / n2;

    Console.WriteLine($"n1 + n2 = {soma}");
    Console.WriteLine($"n1 - n2 = {subtracao}");
    Console.WriteLine($"n1 × n2 = {multiplicacao}");
    Console.WriteLine($"n1 ÷ n2 = {divisao}");
}

operacoes();

List<string> bandas = new List<string>();

bandas.Add("Led Zeppelin");
bandas.Add("Black Sabbath");
bandas.Add("Deep Purple");
bandas.Add("Judas Priest");

void exibirBandas()
{
    for (int i = 0; i < bandas.Count; i++)
    {
        Console.WriteLine(bandas[i]);
    }
}

Console.WriteLine("\n\nBandas preferidas:");
exibirBandas();

List<int> numeros = new List<int> { 1, 2, 3, 4, 5};
int soma = 0;

foreach (int numero in numeros)
{
    soma += numero;
}

Console.WriteLine($"\n\nA soma dos elementos da lista eh: {soma}");


List<int> ns = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("For: \n");
for (int i = 0; i <ns.Count; i++)
{
    if (ns[i] % 2 == 0)
    {
        Console.WriteLine(ns[i]);
    }
}

Console.WriteLine("\nForeach: \n");
foreach (int n in ns)
{
    if (n % 2 == 0)
    {
        Console.WriteLine(n);
    }
}