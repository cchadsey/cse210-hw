using System;

//creating the resume class
public class Resume {

    //setting up the information it needs to store
    public string _name;
    public List<Job> _jobs = new List<Job>();


    //creating the display method so it can output the information it stores.
    public void Display(){

        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs){
            job.Display();
        }
    }


}