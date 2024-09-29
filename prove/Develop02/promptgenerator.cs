using System;


public class PromptGenerator{

    public static string[] _prompts = [
        "What really made you think today?",
        "What goal did you work on today?",
        "Who made the greatest difference in your day?",
        "What did you want to say today that you didn't or couldn't?",
        "What change do you need to make in your daily life?"
    ];

    public string RandomPrompt(){
        Random rand = new Random();

        string prompt = _prompts[rand.Next(5)];

        return prompt;
        
    }

}