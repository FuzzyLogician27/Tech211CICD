using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillarsApp;

internal class Camera:IShootable
{
    private string _brand = "";

    public Camera(string brand)
    {
        _brand = brand;
    }

    public string Shoot()
    {
        return $" takes a picture with their {_brand} camera.";
    }


    public override string ToString()
    {
        return $"{base.ToString()} Brand: {_brand}";
    }

}
