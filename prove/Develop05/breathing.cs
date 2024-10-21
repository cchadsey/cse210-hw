using System;

class BreathingActivity: Activity{

    public BreathingActivity(): base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){


    }

    public void Run(){
        base.DisplayStartingMessage("Breathing");
        int time = base.getDuration();

        DateTime t = DateTime.Now;
        DateTime f = t.AddSeconds(time);

        
        while (DateTime.Now < f){
            Console.WriteLine("Breathe in...");
            base.ShowCountDown(5);
            Console.WriteLine("Breathe Out...");
            base.ShowCountDown(5);
        }
        base.DisplayEndingMessage("Breathing");

    }

}