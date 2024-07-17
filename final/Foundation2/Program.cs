using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "A123", 999.99m, 1),
            new Product("Mouse", "B456", 19.99m, 2)
        };

        List<Product> products2 = new List<Product>
        {
            new Product("Phone", "C789", 599.99m, 1),
            new Product("Charger", "D012", 29.99m, 1)
        };

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());

        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}
