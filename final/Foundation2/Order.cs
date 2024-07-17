using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> Products;
    private Customer Customer;
    private const decimal USA_SHIPPING_COST = 5.0m;
    private const decimal INTERNATIONAL_SHIPPING_COST = 35.0m;

    public Order(List<Product> products, Customer customer)
    {
        Products = products;
        Customer = customer;
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }
        total += Customer.IsInUSA() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;
        return total;
    }

    public string GetShippingLabel()
    {
        return $"{Customer.GetName()}\n{Customer.GetAddress()}";
    }
    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var product in Products)
        {
            sb.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return sb.ToString();
    }

}
