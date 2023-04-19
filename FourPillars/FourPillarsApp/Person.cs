namespace FourPillarsApp;

public class Person : IMoveable, ISpeakable
{
    private string _firstName = "";
    private string _lastName = "";


    #region properties_demo
    // method-based getter and setter
    /*private string _secret = "password12345";

    public string GetSecret(string key)
    {
        if (key == "potatoes") return _secret;
        else return "Invalid key";
    }

    private void SetSecret(string inputValue)
    {
        _secret = inputValue;
    }*/
    #endregion

    // property-based getter and setter
    private int _age = 18;
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value >= 0) _age = value;
        }
    }

    //don't need to create a backing field explicitly if you aren't customising get and set, it's made in the background.
    public double Height { get; set; }

    public Person(string fName, string lName)
    {
        _firstName = fName;
        _lastName = lName;
    }
    public Person(string fName, string lName, int age) : this(fName, lName)
    {
        Age = age;
    }

    // this empty constructor is what's automatically generated if you don't make a constructor.
    public Person() { }

    public virtual string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }

    public string GetFullName(string title)
    {
        return $"{title} {_firstName} {_lastName}";
    }
    public override string ToString()
    {
        return $"{base.ToString()}|| _firstName: {_firstName}, _lastName: {_lastName}, Age: {Age}, Height: {Height}";
    }

    public string Move()
    {
        return "Walking along";
    }

    public string Move(int times)
    {
        return$"{Move()} {times} times";
    }

    public string Speak()
    {
        return "Hello!";
    }
}