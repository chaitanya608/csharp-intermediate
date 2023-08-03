// See https://aka.ms/new-console-template for more information
namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        // var person = Person.Parse("Chaitanya");
        
        // person.Introduce("World");

        var customer = new Customer(1, "Chaitanya");
        
        var order = new Order();
        customer.Orders.Add(order);
        
        Console.WriteLine(customer.Id);
        Console.WriteLine(customer.Name);
    }
}
