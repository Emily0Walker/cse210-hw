public class Product
{
    private string Name;
    private string ProductId;
    private decimal Price;
    private int Quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public string GetName() => Name;
    public string GetProductId() => ProductId;
    public decimal GetPrice() => Price;
    public int GetQuantity() => Quantity;

    public decimal GetTotalCost() => Price * Quantity;
}
