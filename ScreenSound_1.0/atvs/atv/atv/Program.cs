Random aleatorio = new Random();
int numero = aleatorio.Next(1, 100);
int tentativa;

Console.Write("Advinhe um numero de 1 a 100: ");
do
{
    tentativa = int.Parse(Console.ReadLine());
    
    if (tentativa > numero)
    {
        Console.Write("O numero eh menor que o que foi digitado, tente novamente: ");
    } else if (tentativa < numero)
    {
        Console.Write("O numero eh maior que o que foi digitado, tente novamente: ");
    }

} while (numero != tentativa);

Console.WriteLine($"O numero era {numero}.");
Console.WriteLine("Parabens, voce acertou o numero!");