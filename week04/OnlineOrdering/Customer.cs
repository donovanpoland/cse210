public class Customer
{

    //variables
    private string _name;
    private Address _address;

    //constructor
    public Customer()
    {

    }

    //methods
    public bool LiveInUsa() {
        return _address.IsUsa();
    }
}