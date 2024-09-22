using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade percentage?");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        string letter = "";
        
        if (grade >= 90)
        {
            letter = "A";    
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You Passed!");
        }

        else
        {
            Console.WriteLine("Do not pass go, Do not collect passing grade. Try again.");
        }

    }
}