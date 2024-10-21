using System;

class Program
{
    static void Main(string[] args)
    {


        ReflectingActivity reflect = new ReflectingActivity();
        BreathingActivity breathe = new BreathingActivity();
        ListingActivity list = new ListingActivity();

        int option = 0;
        bool run = true;

        while (run == true){
            switch (option){
                default:
                Console.WriteLine("Menu Options");
                Console.WriteLine("   1. Start Breathing Activity");
                Console.WriteLine("   2. Start Reflecting Activity");
                Console.WriteLine("   3. Start Listing Activity");
                Console.WriteLine("   4. Quit");
                Console.WriteLine("Select a choice from the menu:");
                option = int.Parse(Console.ReadLine());
                break;
                
                case 1:
                    breathe.Run();
                    option = 0;
                    break;

                case 2:
                    reflect.Run();
                    option = 0;
                    break;
                case 3:
                    list.Run();
                    option = 0;
                    break;

                case 4:
                    run = false;
                    break;
                }
        }
    }
}