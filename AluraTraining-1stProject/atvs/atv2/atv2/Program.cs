/*
Dictionary<string, List<double>> alunosNotas = new Dictionary<string, List<double>>();
alunosNotas.Add("Carlos", new List<double> { 7, 8, 5});
alunosNotas.Add("Valentina", new List<double> { 3, 7, 6 });
alunosNotas.Add("Monica", new List<double> { 5, 10, 10 });

foreach (var aluno in alunosNotas)
{
    double soma = 0;
    for (int i = 0; i < aluno.Value.Count; i++)
    {
        soma += aluno.Value[i];
    }
    double media = soma / aluno.Value.Count;
    Console.WriteLine($"Media de {aluno.Key}: {media.ToString("F")}");
}
*/

/*
Dictionary<string, int> estoque = new Dictionary<string, int>();
estoque.Add("Cerveja", 7);
estoque.Add("Frango", 21);
estoque.Add("Alcatra", 30);
estoque.Add("Coca", 19);

Console.Write("Qual produto deseja ver a quantidade?: ");
string produto = Console.ReadLine()!;

if (estoque.ContainsKey(produto))
{
    Console.WriteLine($"Quantidade de estoque de {produto}: {estoque[produto]} unidades.");
}
else
{
    Console.WriteLine($"Produto não encontrado no estoque.");
}
*/

/*
Dictionary<string, string> pergsResps = new Dictionary<string, string>
{
    { "Quantas Copas do Brasil o Corinthians tem?", "3" },
    { "Qual o maior goleiro da história do Corinthians", "Cássio" },
    { "Quem foi o símbolo da Democracia Corinthiana?", "Sócrates" },
};

int pontos = 0;

foreach (var pergunta in pergsResps)
{
    Console.WriteLine(pergunta.Key);
    Console.Write("Sua resposta: ");
    string respostaUser = Console.ReadLine()!;

    if (respostaUser.ToLower() == pergunta.Value.ToLower())
    {
        Console.WriteLine("Correto!\n");
        pontos++;
    }
    else
    {
        Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n");
    }
}

Console.WriteLine($"Pontos: {pontos} de {pergsResps.Count}");
*/

/*
Dictionary<string, string> users = new Dictionary<string, string>
{
    { "user1", "senha123" },
    { "user2", "abc456" },
};

Console.Write("Qual o nome de user?: ");
string nomeUser = Console.ReadLine()!;
Console.Write("Qual a senha?: ");
string senha = Console.ReadLine()!;

if (users.ContainsKey(nomeUser) && users[nomeUser] == senha)
    Console.WriteLine("Login bem-sucedido!");
else
    Console.WriteLine("Nome de usuário ou senha incorretos.");
*/