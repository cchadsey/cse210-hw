using System;

class Product{
    string _name;
    int _prodID;
    double _price;
    int _quantity;


    public Product(string name, int prodID, double price, int quantity){
        _name = name;
        _prodID = prodID;
        _price = price;
        _quantity = quantity;
    }
    public double TotalCost(){
        double pay = _price * _quantity;
        return pay;
    }
    public string PackList(){
        string note = $"{_name}, {_prodID}.";
        return note;
    }
}