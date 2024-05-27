class Conta
{
    public string titular { get; set; }
    public int id { get; set; }
    public float saldo { get; set; }
    public int senha { get; set; }

    public void exibirInformacoes()
    {
        Console.WriteLine("-> INFORMAÇÕES DA CONTA:\n");
        Console.WriteLine($"Titular: {this.titular}");
        Console.WriteLine($"Saldo atual: R${this.saldo}");
    }
}