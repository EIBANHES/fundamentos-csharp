namespace FundamentosCsharp;

class Program
{
    static void Main(string[] args)
    {
        string nome = RetornaNome("Emanuel", "Ibanhes");
        Console.WriteLine(nome);
    }

    static void MeuMetodo()
    {
        Console.WriteLine("C# é legal");
    }

    static string RetornaNome(string nome, string sobrenome, int idade = 18)
    {
        return $"{nome} {sobrenome}";
    }
}