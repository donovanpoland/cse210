using System.Security.Cryptography.X509Certificates;

public class Order
{

    //variables
    private List<Product> _products;
    Product _product = new Product();
    private Customer _customer;

    //constructors
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    //methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal(Product product)
    {
        double total = 0;
        //calculate the total of products
        for (int i = 0; i < _products.Count; i++)
        {
            total += (product.GetPrice() * product.GetQuantity());
        }

        return total;
    }

    public void DisplayReceipt()
    {
        if (_products.Count > 0)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                Console.WriteLine($"{_products[i]}");
            }
            Console.WriteLine(CalculateTotal(_product));
        }
        else
        {
            Console.WriteLine("No Products ordered.");
        }
    }

    public void PackingLabel()
    {
        _customer.
    }


}