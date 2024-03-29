﻿// See https://aka.ms/new-console-template for more information
namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        // var person = Person.Parse("Chaitanya");
        
        // person.Introduce("World");
        
        // UsePoints();
        // UseParams();
        // UseModifier();
        // UseCustomer();
        // UsePerson();
        UseHttpCookie();
    }

    static void UseHttpCookie()
    {
        var cookie = new HttpCookie();
        cookie["name"] = "Chaitanya";
        Console.WriteLine(cookie["name"]);
    }

    static void UsePerson()
    {
        var person = new Person(new DateTime(1991, 4, 1));

        Console.WriteLine(person.Age);
    }

    static void UseCustomer()
    {
        var customer = new Customer(608, "Chaitanya");
        
        customer.Orders.Add(new Order());
        customer.Orders.Add(new Order());
        customer.Promote();

        Console.WriteLine(customer.Id);
        Console.WriteLine(customer.Name);
        Console.WriteLine(customer.Orders.Count);
    }

    static void UseModifier()
    {
        var result = int.TryParse("123789", out var number);
        if (result)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Conversion failed");
        }
    }

    static void UseParams()
    {
        var calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Add(1, 2, 3));
        Console.WriteLine(calculator.Add(new int[]{1, 2, 3, 4}));
    }

    static void UsePoints()
    {
        try
        {
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            Console.WriteLine($"Point is at ({point.X}, {point.Y})");
        
            point.Move(null);
            Console.WriteLine($"Point is at ({point.X}, {point.Y})");
        }
        catch (Exception e)
        {
            Console.WriteLine("an unexpected error occurred");
            // throw;
        }
    }
}
