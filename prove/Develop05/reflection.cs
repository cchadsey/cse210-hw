using System;

class ReflectingActivity: Activity{

    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>{
        "Why was this experience maningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mine in the future?"
    
    };

    public ReflectingActivity(): base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){
        
    }

    public void Run(){
        base.DisplayStartingMessage("Reflecting");
        string prompt = GetRandomPrompt();
        int time = base.getDuration();
        DisplayPrompt(prompt);
        base.ShowCountDown(5);

        DateTime t = DateTime.Now;
        DateTime f = t.AddSeconds(time);

        
        while (DateTime.Now < f){
            string question = GetRandomQuestion();
            DisplayQuestion(question);
            base.ShowSpinner(10);
        
        }
        base.DisplayEndingMessage("Reflecting");

    }

    public string GetRandomPrompt(){
        Random rnd = new Random();

        string prompt = _prompts[rnd.Next(_prompts.Count())];

        return prompt;
    }

    public string GetRandomQuestion(){
        Random rnd = new Random();

        string question = _questions[rnd.Next(_questions.Count())];

        return question;
    }

    public void DisplayPrompt(string prompt){

        Console.WriteLine(prompt);

    }

    public void DisplayQuestion(string question){

        Console.WriteLine(question);

    }


}