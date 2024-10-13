using System;

class Order{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
    }




    public void AddProduct(Product prod){
        _products.Add(prod);

    }
    public void CalculatePrice(){
        double pay = 0.00;
        foreach (Product prodd in _products){
            pay += prodd.TotalCost();
        }
        pay += ShippingCost();
        string total = pay.ToString("F2");
        Console.Write("Total Cost: $");
        Console.Write("{0: 0.00}" ,pay);
        Console.WriteLine("");
 

    }
    public double ShippingCost(){
        double ship = 0;
        if (_customer.IsUSA() == true){
            ship = 5.00;
        }
        else{
            ship = 35.00;
        }
        return ship;

    }
    public void ShippingLabel(){
        Console.WriteLine(_customer.getName());
        Console.WriteLine( _customer.getAddress());
        Console.WriteLine("");
    }
    public void PackingLabel(){
        foreach (Product prod in _products){
            Console.WriteLine(prod.PackList());
        }
        Console.WriteLine("");
    }
}