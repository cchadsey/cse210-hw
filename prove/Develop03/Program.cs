using System;


//As per the assignment specifications, for my stretch challenge i decided to make my program check and only choose words to hide that weren't already hidden.
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and He shall direct thy paths.");
        int  doHide = 3;
        string response = null;

        do {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Please press enter to hide words, or type 'quit' to end program.");
            response = Console.ReadLine();
        
            bool hidden = scripture.IsCompletelyHidden();


            if (hidden == true){
                response = "quit";
            }
            else{
                scripture.HideRandomWords(doHide);
            }
            
        }while (response.ToLower() != "quit");

    }
}