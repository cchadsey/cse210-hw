using System;

class Program
{
    static void Main(string[] args)
    {


        Activity reflect = new Activity ReflectingActivity(): base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Activity breathe = new Activity BreathingActivity(): base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Activity list = new Activity ListingActivity(): base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")

        int option = o
        bool run = true

        while (run == true){
            switch (option){
                default:
                Console.WriteLine("Menu Options");
                Console.WriteLine("   1. Start Breathing Activity");
                Console.WriteLine("   2. Start Reflecting Activity");
                Console.WriteLine("   3. Start Listing Activity");
                Console.WriteLine("   4. Quit");
                Console.WriteLine("Select a choice from the menu:");
                option = Console.ReadLine();
                
                case 1:
                    breathe.Run();

                case 2:
                    reflect.Run();
                case 3:
                    list.Run();
                case 4:
                    run = false;
                    break;
                }
        }
    }
}