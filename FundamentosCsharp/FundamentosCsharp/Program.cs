namespace FundamentosCsharp;

class Program
{
    static void Main(string[] args)
    {
        var arr = new string[2];
        arr[0] = "item 1";
        var arr2 = arr;

        Console.WriteLine(arr[0]);
        Console.WriteLine(arr2[0]);

        arr[0] = "item 2";
        Console.WriteLine(arr[0]);
        Console.WriteLine(arr2[0]);
    }    
}