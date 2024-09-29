using System;


class Program
{
      static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Hello! Welcome to the Journal Program!");
        
        Menu menu = new Menu();

        int choice = 0;

        while (choice != 5 ){

            choice= menu.Choose();

            switch(choice){

                case 1:
                    journal.AddEntry();
                    break;
                
                case 2:
                    journal.DisplayAll();
                    break;
                
                case 3:
                    journal.LoadFromFile();
                    break;
                
                case 4:
                    journal.SaveToFile();
                    break;
                    
                case 5:
                    break;

                default:
                    Console.WriteLine("That is not a valid choice, please try again.");
                    break;

                
            }
        }

    }
}