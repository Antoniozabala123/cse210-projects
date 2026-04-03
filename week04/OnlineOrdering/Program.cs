using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Online Ordering System ===\n");

        // order1
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Maria Lopez", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-001", 29.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "KB-202", 89.99, 1));
        order1.AddProduct(new Product("Gaming Headset", "GH-505", 59.99, 3));

        Console.WriteLine("--- Order 1 ---");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\n" + order1.GetPackingLabel());
        Console.WriteLine($"\nTotal Cost: ${order1.CalculateTotalCost():F2}\n");

        // order 2
        Address address2 = new Address("Av. Rivadavia 4567", "Buenos Aires", "CABA", "Argentina");
        Customer customer2 = new Customer("Carlos Ramirez", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Dell XPS", "LT-789", 1299.99, 1));
        order2.AddProduct(new Product("Mouse Pad", "MP-100", 15.99, 5));

        Console.WriteLine("--- Order 2 ---");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\n" + order2.GetPackingLabel());
        Console.WriteLine($"\nTotal Cost: ${order2.CalculateTotalCost():F2}");

        Console.WriteLine("\nProgram finished.");
    }
}

