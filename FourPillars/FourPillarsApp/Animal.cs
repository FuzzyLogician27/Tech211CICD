
using System.Buffers;

namespace FourPillarsApp;

public abstract class Animal : ISpeakable
{
    private string _name;
    public string Kingdom { get; set; }
    public int Legs { get; set; } = 0;
    public DateTime Age { get; set; }
    public bool hasTail { get; set; }

    public Animal() 
    {
        _name = "Bob";
    }

    public abstract string Speak();
    public virtual double Move()
    {
        return 0d;
    }

}

public class Dog : Animal
{
    public double Speed { get; set; } = 10;
    public override string Speak()
    {
        return "Bark";
    }

    public override sealed double Move()
    {
        return Speed;
    }
}

public class Corgi : Dog
{
    public int LegSize { get; set; } = 1;
    /*public override double Move()
    {

    }*/
}

public class Cat : Animal
{
    public override string Speak()
    {
        return "Meow";
    }
}
public class Bird : Animal
{
    public override string Speak()
    {
        return "Cheep";
    }
}