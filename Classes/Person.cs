namespace Classes;

public class Person
{
    public string Name;
    private DateTime _birthdate;

    public void Introduce(string to)
    {
        Console.WriteLine($"Hello {to}, I am {Name}.");
    }

    public void SetBirthdate(DateTime birthdate)
    {
        _birthdate = birthdate;
    }

    public DateTime GetBirthdate()
    {
        return _birthdate;
    }

    public static Person Parse(string str)
    {
        var person = new Person();
        person.Name = str;

        return person;
    }
}
