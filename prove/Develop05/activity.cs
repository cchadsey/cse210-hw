using System;

class Activity{
    private string _name;

    private string _description;

    private int _duration;

    public Activity(string name,string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;

    }

    public void DisplayStartingMessage(){

    }

    public void DisplayEndingMessage(){

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
            p --;;
        }


    }
}
