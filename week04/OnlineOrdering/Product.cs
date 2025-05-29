public class Product
{

    //variables
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;


    //constructors
    public Product()
    {
        
    }

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //methods
    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
       return _quantity;
    }

    public string DisplayProduct()
    {
        return $"ID: {_productId} Product: {_name} Price: {_price} Quantity: {-_quantity}";
    }



}