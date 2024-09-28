using System;


//making the job class
public class Job {

    //setting up the information it needs to store 
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


    //setting up its display method.
    public void Display(){

        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");

    }
}