namespace Classes;

class Customer
{
    public int Id;
    public string Name;
    readonly public List<Order> Orders = new List<Order>();

    public Customer(int id)
    {
        this.Id = id;
    }

    public Customer(int id, string name) : this(id)
    {
        this.Name = name;
    }

    public void Promote()
    {
        // ...
        Console.WriteLine("Customer promoted");
    }
}
