using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        Order order = new Order(customer);
        Product product1 = new Product("battery", 1, 10.00, 3);

        order.AddProduct(product1);
        order.DisplayReceipt();
    }
}