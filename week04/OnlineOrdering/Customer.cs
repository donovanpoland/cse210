public class Customer
{

    //variables
    private string _name;
    private Address _address;

    //constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //methods
    public bool LiveInUsa()
    {
        return _address.IsUsa();
    }

    public string GetShippingInfo()
    {
        return $"{_name}\n{_address.DisplayAddress()}";
    }
}