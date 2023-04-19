namespace FourPillarsApp;

public class Program
{
    static void Main()
    {
        /*Person andrew = new Person("Andrew", "Ma");
        //andrew.Age = 22;
        Console.WriteLine(andrew.GetFullName("Mr"));
        //andrew._firstName = "Andy" returns an error because _firstName is Private

        Person talal = new Person("Talal", "Hassan", 22);


        // object initialisers
        var patrick = new Person("Patrick", "Ardagh") { Age = 24, Height = 300 };
        int[] array = new int[] { 1, 2, 3 };
        List<int> list = new List<int> { 1, 4, 7 };

        // C# will secretly create an empty constructor in the background
        Park park = new Park() { Roundabouts = 1, Swings = 10, ParkManager = new Person("Dave", "Davidson") };


        Point3D point = new Point3D(1, 2);
        //Point3D theresAlwaysABlankConstructor = new Point3D();
        //Point3D empty;

        DoThis(point, patrick);

        Hunter danielle = new Hunter("Danielle", "Massey", "Kodak");
        Console.WriteLine(danielle.ToString());

        Hunter idris = new("Idris", "Ahmed", "Cannon");

        Console.WriteLine($"idris Equals danielle? {idris.Equals(danielle)}");
        Console.WriteLine($"idris HashCode: {idris.GetHashCode()}");
        Console.WriteLine($"idris Type: {idris.GetType()}");
        Console.WriteLine($"idris ToString: {idris}");


        Airplane a = new Airplane(200, 100, "JetsRUs")

        { NumPassengers = 150 };

        a.Ascend(500);

        Console.WriteLine(a.Move(3));

        Console.WriteLine(a);

        a.Descend(200);

        Console.WriteLine(a.Move());

        a.Move();

        Console.WriteLine(a);

        var myDog = new Dog();
        var myCat = new Cat();
        var myBird = new Bird();

        Console.WriteLine(myDog.Speak());
        Console.WriteLine(myCat.Speak());
        Console.WriteLine(myBird.Speak());

        Console.WriteLine("\nPolymorphism demo: \n");
        List<Animal> animals = new List<Animal>() { myDog, myCat, myBird };
        foreach(var animal in animals)
        {
            Console.WriteLine(animal.Speak());
        }
        Console.WriteLine();

        Animal myAnimal;
        string input = Console.ReadLine();
        switch (input.ToLower())
        {
            case "dog":
                myAnimal = new Dog();
                break;
            case "cat":
                myAnimal = new Cat();
                break;
            case "bird":
                myAnimal = new Bird();
                break;
            default:
                Console.WriteLine("Not an animal :(");
                myAnimal = null;
                break;
        }
        if(myAnimal is not null) Console.WriteLine(myAnimal.Speak());*/
        /*
        List<Object> gameObjects = new List<Object>()
        {
            new Airplane(15),
            new Dog(),
            new Cat(),
            new Park(),
            new Person("Jacob", "Banyard"),
            new Hunter("Majid","Laklouk","Nikon"),
            new Vehicle()
        };

        foreach(var obj in gameObjects)
        {
            SpartaWrite(obj);
            if(obj is Animal)
            {
                Animal a = (Animal)obj;
                SpartaWrite(a.Speak());
            }
        }

        List<IMoveable> moveables = new()
        {
            new Person("Jacob", "Banyard"),
            new Hunter("Majid","Laklouk","Nikon"),
            new Vehicle(),
            new Airplane(25)
        };

        foreach(var m in moveables)
        {
            SpartaWrite(m.Move(2));
        }*/

        List<IShootable> weapons = new()
        {
            new LaserGun("Blaster"),
            new WaterPistol("Super Soaker"),
            new Trebuchet("Trebuchet"),
            new Bazooka("Mortar"),
            new Hunter("Me", "Myself", new LaserGun("Gat")),
            new Hunter("Just", "SomeGuy", new Camera("Nikon"))
        };

        foreach(var w in weapons)
        {
            SpartaWrite(w.Shoot());
        }
    }

    public static void DoThis(Point3D p, Person person)
    {
        p.x = 1000;
        person.Age = 99;
    }

    public static void SpartaWrite(Object obj)
    {
        Console.WriteLine($"Sparta says: {obj}");
    }
}