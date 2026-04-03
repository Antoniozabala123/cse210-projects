using System;
using System.Collections.Generic;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }
    private double GetShippingCost()
    {
        return _customer.LivesInUSA() ? 5.00 : 35.00;
    }
    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        total += GetShippingCost();
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:";

        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:{_customer.GetName()}{_customer.GetAddress().GetFullAddress()}";
    }
}