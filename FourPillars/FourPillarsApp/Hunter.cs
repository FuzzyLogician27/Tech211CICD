

namespace FourPillarsApp;

internal class Hunter : Person, IShootable
{

    public IShootable Shooter { get; set; }

    public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
    {
        Shooter = shooter;
    }

    public string Shoot()
    {
        return $"{base.GetFullName()} {Shooter.Shoot()}";
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Shooter: {Shooter}";
    }

    public override string GetFullName()
    {
        return $"Hunter {base.GetFullName()}";
    }

}
