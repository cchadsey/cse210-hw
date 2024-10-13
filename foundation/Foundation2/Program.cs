using System;

class Program
{
    static void Main(string[] args)
    {
        //order 1
        Product prod1 = new Product("Fuzzy Slippers", 14211, 4.99, 2);
        Product prod2 = new Product("Cow Foot Rest", 300, 145.23, 1);
        Product prod3 = new Product("German Button Shiner", 9999, 14.95, 1);
        Address address1 = new Address("123 way st", "Pink", "Oklahoma", "USA");
        Customer customer1 = new Customer("John Likestuff", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);
        order1.AddProduct(prod3);

        Console.WriteLine("Order 1");
        order1.PackingLabel();
        order1.ShippingLabel();
        Console.WriteLine($"Shipping Cost: ${order1.ShippingCost()}");
        order1.CalculatePrice();
        Console.WriteLine("");


        //order 2

        Product prod21 = new Product("Automatic Meal Burner", 829, 5.99, 1);
        Product prod22 = new Product("All Metal Bath Robe", 1441, 146.98, 6);
        Product prod23 = new Product("Purple Pet Watcher", 7928, 82.15, 3);
        Address address12 = new Address("234 Albrict st", "Yourk", "Berlin", "Germany");
        Customer customer12 = new Customer("Luke Hatenstuff", address12);
        Order order12 = new Order(customer12);
        order12.AddProduct(prod21);
        order12.AddProduct(prod22);
        order12.AddProduct(prod23);

        Console.WriteLine("Order 2");
        order12.PackingLabel();
        order12.ShippingLabel();
        Console.WriteLine($"Shipping Cost: ${order12.ShippingCost()}");
        order12.CalculatePrice();
    }
}