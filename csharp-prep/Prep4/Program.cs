using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Set up list to be used in the loop
        List<int> numbers = new List<int>();
        
        //set up boolean i'll use to check for when the loop should end
        bool onward = true;

        //introduce the user request
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //setting up the loop
        do
        {
            //prompting user for entry.
            Console.Write("Enter a number:");
            
            //variable for the entry
            string ans = Console.ReadLine();
            int answer = int.Parse(ans);

            //add it to the list if it isnt 0
            if (answer !=0)
            {
                numbers.Add(answer);
            }

            //check the entry for 0 to see if we should stop. i chose to check if its 0 to make sure the user input an integer.
            if (answer == 0)
            {
                //update boolean if we should stop
                onward = false;
            }
            

        }while (onward == true); //check boolean to see if we should continue.

        //its worth noting that there is a possible simple solution using "numbers.sum()" however, i will be incorporating a loop to get some more practice with c#.
        int sum = 0;
        int large = 0;
        int length = numbers.Count;
        float average = 0;

            foreach (int item in numbers)
            {
                if (item >= large)
                {
                    large = item;
                }
               sum += item;
            }
        
        Console.WriteLine($"The sum is: {sum}");

        average = ((float)sum)/length;

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {large}");


    }
}