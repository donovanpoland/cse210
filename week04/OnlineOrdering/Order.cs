using System.Security.Cryptography.X509Certificates;

public class Order
{

    //variables
    private List<Product> _products;
    private Customer _customer;

    //constructors
    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;
        _products = products;
    }

    //methods
    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        if (_customer.LiveInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} | ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingInfo();
    }

}