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

    public ListingActivity(): base(string name, string description, int duration){

    }

    public void Run(){
        base.DisplayStartingMessage("Listing");
        int time = base.getDuration();

        GetRandomPrompt();
       

        base.ShowCountDown(10);

        List<string> userlist = GetListFromUser(time);

        Console.WriteLine($"You entered {userlist.count()} items!");

        base.DisplayEndingMessage("Listing");



    }

    public void GetRandomPrompt(){
        Random rnd = new Random();

        prompt = _prompts[rnd.Next(_prompts.count())];

        Console.WriteLine(prompt);

    }

    public List<string> GetListFromUser(int seconds){

        List<string> userList = new List<string>();

        DateTime t = DateTime.Now;
        DateTime f = t.AddSeconds(seconds);

        
        while (DateTime.Now < f){

            Console.Write(">")
            string input =  Console.ReadLine();
            userList.Add(input);

        }

    
       return userList;
    }
}