class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("0 - Sair");
        Console.WriteLine("S - Timer em segundos");
        Console.WriteLine("M - Timer em minutos");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();

        char type = char.Parse(data.Substring( data.Length - 1, 1) ); // pegando o último caracter
        int time = int.Parse(data.Substring(0, data.Length - 1));

        int multiplier = 1;

        if (type == 'm')
            multiplier = 60;

        if (time == 0)
            System.Environment.Exit(0);

        Start(time * multiplier);
    }


    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000); // esperar por 1 segundo 
        }

        Console.Clear();
        Console.WriteLine("Cronometro finalizado!");
        Thread.Sleep(2000); // esperar por 1 segundo 
    }
}