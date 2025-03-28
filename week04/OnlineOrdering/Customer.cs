public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        if (_address.IsInUSA())
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"{_name}\n{_address.GetFullAddress()}";
        return shippingLabel;
    }
    
}
