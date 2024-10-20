using System;

class ListingActivity: Activity{
    
    private int _count;

    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heros?"
    }

    public ListingActivity(): base(){

    }

    public void Run(){
        base.DisplayStartingMessage()
        

        GetRandomPrompt()

        base.ShowCountDown(10);



    }

    public void GetRandomPrompt(){
        Random rnd = new Random();

        prompt = _prompts[rnd.Next(_prompts.count())];

        Console.WriteLine(prompt);

    }

    public List<string> GetListFromUser(){

        List<string> userList = new List<string>();
    
        while (){


            string input =  Console.ReadLine();
            userList.Add(input);

        }

    
       return userList;
    }
}