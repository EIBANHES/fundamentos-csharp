namespace FundamentosCsharp;

class Program
{
    static void Main(string[] args)
    {
        var product = new Product(1, "Mouse Gamer", 299.9, EProductType.Product);
        Console.WriteLine(product.Type);
        Console.WriteLine((int)product.Type); // conversao explicita
    }    
}

struct Product
{
    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

    public Product(int id, string name, double price, EProductType type)
    {
        Id = id;
        Name = name;
        Price = price;
        Type = type;
    }

    public double PriceInDolar(double dolar)
    {
        return Price * dolar;
    }
}

enum EProductType
{
    Product = 1,
    Service = 2
}