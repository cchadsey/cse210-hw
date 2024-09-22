using System;

class Program
{
    static void Main(string[] args)
    {
        //making functions.

        //function to Display a welcome message.
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        //function to Ask for user name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        //function to ask for their favorite number.
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string response = Console.ReadLine();
            int number = int.Parse(response);
            return number;
        }

        //function to square the user's favorite number.
        static int SquareNumber(int userNumber)
        {
            int square = userNumber * userNumber;
            return square;
        }

        //function to display the desired output after asking for inputs and processing any math.
        static void DisplayResult(string name, int square)
        {
            Console.Write($"{name}, the square of your number is {square}");
        }

        //the main function where we put it all together. 
        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int square = SquareNumber(number);
            DisplayResult(name, square);
        }

        //calling that main function.
        Main();
    }
}