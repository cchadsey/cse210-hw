using System;

class Program
{
    static void Main(string[] args)
    {
        bool correct = false;
        int guesses = 0;
        
        
        Console.WriteLine("Computer is Choosing a number between 1 and 100");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.WriteLine("The computer has chosen a nubmer.");
        
        do
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            int theGuess = int.Parse(guess);

            if (theGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (theGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
                correct= true;
            }
            guesses ++;

        }while (correct == false);
        Console.WriteLine($"It took you {guesses} tries!");
    }
}