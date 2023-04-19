using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillarsApp;

public abstract class Weapon : IShootable
{
    private string _brand = "";


    public virtual string Shoot()
    {
        return $" sets off their {_brand}.";
    }

    public override string ToString()
    {
        return $"{base.ToString()} Brand: {_brand}";
    }

    public Weapon(string brand)
    {
        _brand = brand;
    }
}

public class LaserGun : Weapon
{
    public LaserGun(string brand):base(brand)
    {
        
    }

    public override string Shoot()
    {
        return $"{base.Shoot()} Zing!!";
    }


}

public class WaterPistol : Weapon
{
    public WaterPistol(string brand) : base(brand)
    {

    }

    public override string Shoot()
    {
        return $"{base.Shoot()} Pshew!!";
    }


}

public class Trebuchet : Weapon
{
    public Trebuchet(string brand) : base(brand)
    {

    }

    public override string Shoot()
    {
        return $"{base.Shoot()} Thunk!!";
    }


}

public class Bazooka : Weapon
{
    public Bazooka(string brand) : base(brand)
    {

    }

    public override string Shoot()
    {
        return $"{base.Shoot()} BOOM!!";
    }


}

