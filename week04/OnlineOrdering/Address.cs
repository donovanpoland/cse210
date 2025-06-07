using System.Reflection.Metadata.Ecma335;

public class Address
{

    //variables
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _zipCode;

    //constructors
    // public Address()
    // {
    //     //default
    // }

    public Address(string street, string city, string state, string country, string zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zipCode = zipCode;
    }

    //methods
    public bool IsUsa()
    {
        return _country.Trim().ToLower() == "usa";
    }

    public string DisplayAddress()
    {
        //standard US format
        return $"{_street}\n{_city}, {_state} {_zipCode}\n{_country}";
    }









}