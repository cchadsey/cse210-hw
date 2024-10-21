using System;

class Activity{
    private string _name;

    private string _description;

    private int _duration;

    public Activity(string name,string description){
        _name = name;
        _description = description;
   

    }
    public int getDuration(){
        return _duration;
    }

    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name} Activity. {_description} How long would you like this session to last? (in seconds)");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        Console.WriteLine($"Please Prepare to beigin the {_name} Activity.");
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("Wonderful Job!");
        Thread.Sleep(3000);
        Console.WriteLine($"You completed the {_name} Activity, Which lasted for {_duration} seconds.");
        Thread.Sleep(4000);
    }

    public void ShowSpinner(int seconds){
        DateTime t = DateTime.Now;
        DateTime f = t.AddSeconds(seconds);

        
        while (DateTime.Now < f){

            for (int i = 5; i > 0; i--){
                Console.Write("+");
                Thread.Sleep(100);
            }
            for (int i = 5; i > 0; i--){ 
                Console.Write("\b \b");
                Thread.Sleep(100);
            }
        }


    }
    public void ShowCountDown(int seconds){

        int p = seconds;

        while (p > 0 ){
            
            Console.Write(p);
            Thread.Sleep(1000);
            p --;
        }


    }
}
