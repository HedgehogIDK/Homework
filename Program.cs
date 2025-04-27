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

 public class Device
{
    protected string Name;
    protected string Characteristics;

    public Device(string name, string characteristics)
    {
        Name = name;
        Characteristics = characteristics;
    }

    public virtual void Sound() { }

    public void Show()
    {
        Console.WriteLine($"Устройство: {Name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Характеристики: {Characteristics}");
    }
}

class Kettle : Device
{
    public Kettle(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Чайник: шипит...");
    }
}

class Microwave : Device
{
    public Microwave(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Микроволновка: пищит...");
    }
}

class Car : Device
{
    public Car(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Автомобиль: врум-врум!");
    }
}

class Steamship : Device
{
    public Steamship(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Пароход: гудит...");
    }
}

 public class MusicalInstrument
{
    protected string Name;
    protected string Characteristics;

    public MusicalInstrument(string name, string characteristics)
    {
        Name = name;
        Characteristics = characteristics;
    }

    public virtual void Sound() { }

    public void Show()
    {
        Console.WriteLine($"Инструмент: {Name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Характеристики: {Characteristics}");
    }

    public virtual void History() { }
}

class Violin : MusicalInstrument
{
    public Violin(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Скрипка: красивое пение струн...");
    }

    public override void History()
    {
        Console.WriteLine("Скрипка появилась в XVI веке в Италии.");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Тромбон: мощный трубный звук...");
    }

    public override void History()
    {
        Console.WriteLine("Тромбон появился в XV веке в Германии.");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Укулеле: лёгкое бренчание...");
    }

    public override void History()
    {
        Console.WriteLine("Укулеле появилась на Гавайях в XIX веке.");
    }
}

class Cello : MusicalInstrument
{
    public Cello(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Виолончель: глубокий бархатный звук...");
    }

    public override void History()
    {
        Console.WriteLine("Виолончель появилась в XVI веке в Италии.");
    }
}