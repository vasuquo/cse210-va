using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        
        Console.Write("Enter Customer Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Customer Address as follows: ");
        Console.Write("Enter street: ");
        string street = Console.ReadLine();
        Console.Write("Enter city: ");
        string city = Console.ReadLine();
        Console.Write("Enter state: ");
        string state = Console.ReadLine();
        Console.Write("Enter country: ");
        string country = Console.ReadLine();

        Address address = new Address(street, city, state, country);
        Customer customer = new Customer(name, address);

        Product product1 = new Product(100,"Adidas T-Shirt", 15.5f, 5);
        Product product2 = new Product(100,"Snickers", 25f, 10);
        Product product3 = new Product(100,"Gucci bag", 30.5f, 2);

        products.Add(product1);
        products.Add(product2);
        products.Add(product3);

        Order order = new Order(customer, products);
        Console.Clear();
        order.PackingLabel();
        order.ShippingLabel();
        Console.WriteLine($"Total Order Cost: {order.GetTotalOrderCost()}");
    }
}