using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "San Francisco", "CA", "USA");
        Address address3 = new Address("789 Oak St", "Chicago", "IL", "USA");
        Address address4 = new Address("321 Maple Ave", "London", "England", "UK");

        Product product1 = new Product("Product 1", "P1", 10.99m, 2);
        Product product2 = new Product("Product 2", "P2", 5.99m, 3);
        Product product3 = new Product("Product 3", "P3", 15.99m, 1);

        Customer customer1 = new Customer("Customer 1", address1);
        Customer customer2 = new Customer("Customer 2", address4);

        List<Product> order1Products = new List<Product> { product1, product2 };
        Order order1 = new Order(order1Products, customer1);

        List<Product> order2Products = new List<Product> { product2, product3 };
        Order order2 = new Order(order2Products, customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
        Console.WriteLine();
    }
}