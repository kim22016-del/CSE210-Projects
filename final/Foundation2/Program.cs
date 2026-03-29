using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1N 2S", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Jane Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L101", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M123", 25.50, 2));

        Address address2 = new Address("45-2", "Seoul", "Gangnam", "South Korea");
        Customer customer2 = new Customer("Minkyu Kim", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "L1235", 299.00, 1));
        order2.AddProduct(new Product("Keyboard", "K90", 45.00, 1));

        Console.WriteLine("--- Order 1 ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotal()}\n");

        Console.WriteLine("--- Order 2 ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotal()}");
    }
}