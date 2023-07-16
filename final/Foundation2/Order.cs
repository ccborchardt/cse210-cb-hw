using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;

    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }

    public Customer Customer
    {
        get { return customer; }
        set { customer = value; }
    }

    public Order(List<Product> products, Customer customer)
    {
        Products = products;
        Customer = customer;
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product product in Products)
        {
            totalPrice += product.GetTotalPrice();
        }
        if (Customer.IsInUSA())
        {
            totalPrice += 5; // USA shipping cost
        }
        else
        {
            totalPrice += 35; // International shipping cost
        }
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in Products)
        {
            packingLabel += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Customer: {Customer.Name}\nAddress: {Customer.Address.GetFullAddress()}";
        return shippingLabel;
    }
}

