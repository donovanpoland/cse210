using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA", "62704");
        Address address2 = new Address("456 Elm Ave", "Toronto", "ON", "Canada", "M4B 1B4");

        Customer customer1 = new Customer("Alice Johnson", address1);
        Customer customer2 = new Customer("Bob Smith", address2);

        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", 101, 999.99m, 1),
            new Product("Mouse", 102, 25.00m, 2)
        };

        List<Product> products2 = new List<Product>
        {
            new Product("Desk Lamp", 201, 40.00m, 1),
            new Product("Notebook", 202, 3.50m, 5)
        };

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("\n----------------");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nTotal Cost: ${order.GetTotalCost()}");
            Console.WriteLine("----------------");
        }
    }
}