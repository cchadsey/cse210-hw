using System;

class Customer{
    Address _address;
    string _name;
    bool _isUSA;


    public Customer(string name, Address address){
        _name = name;
        _address = address;
        _isUSA = address.IsUSA();
    }
    public bool IsUSA(){
        return _address.IsUSA();
    }
    public string getAddress(){
        string address = _address.FullAddress();

        return address;
    }
    public string getName(){
        string name = _name;
        return name;
    }
}