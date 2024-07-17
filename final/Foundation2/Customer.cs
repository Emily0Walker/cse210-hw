public class Customer
{
    private string Name;
    private Address Address;

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public string GetName() => Name;
    public Address GetAddress() => Address;

    public bool IsInUSA() => Address.IsInUSA();
}
