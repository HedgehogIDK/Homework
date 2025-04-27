class Money
{
    protected int Whole;
    protected int Cents;

    public Money(int whole = 0, int cents = 0)
    {
        Whole = whole;
        Cents = cents;
    }

    public void SetMoney(int whole, int cents)
    {
        Whole = whole;
        Cents = cents;
    }

    public void Display()
    {
        Console.WriteLine($"Сумма: {Whole} единиц и {Cents} копеек");
    }
}

class Product : Money
{
    private string Name;

    public Product(string name, int whole, int cents) : base(whole, cents)
    {
        Name = name;
    }

    public void ReducePrice(int whole, int cents)
    {
        int totalCents = Whole * 100 + Cents;
        int reduceCents = whole * 100 + cents;
        int newTotal = Math.Max(totalCents - reduceCents, 0);

        Whole = newTotal / 100;
        Cents = newTotal % 100;
    }

    public void ShowProduct()
    {
        Console.WriteLine($"Товар: {Name}, цена: {Whole} единиц и {Cents} копеек");
    }
}