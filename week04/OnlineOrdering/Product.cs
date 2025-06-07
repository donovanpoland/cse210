public class Product
{

    //variables
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;


    //constructors
    public Product()
    {

    }

    public Product(string name, int productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //methods
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productId;
    }


}