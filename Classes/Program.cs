// See https://aka.ms/new-console-template for more information
namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        var person = Person.Parse("Chaitanya");
        
        person.Introduce("World");
    }
}
