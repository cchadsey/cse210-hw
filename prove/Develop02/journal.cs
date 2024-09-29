using System;
using System.IO;

public class Journal{

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(){
        Entry entry = new Entry();
        
        DateTime theDate = DateTime.Now;
        string date = theDate.ToShortDateString();

        entry._date = date;
        
        PromptGenerator promptlist = new PromptGenerator();
        string prompt = promptlist.RandomPrompt();
        entry._promptText = prompt;

        Console.WriteLine($"{prompt}");
        Console.Write(">");
        entry._entryText = Console.ReadLine();

        _entries.Add(entry);


    }

    public void DisplayAll(){
        foreach (Entry Entry in _entries){
            Entry.Display();
            Console.WriteLine(); 
        }
    }

    public void SaveToFile(){
        Console.WriteLine("Who's journal are you saving?");
        string fileName = Console.ReadLine();

        string file = $"{fileName}.txt";

        using (StreamWriter outputFile = new StreamWriter (file)){
            foreach (Entry entry in _entries){
                outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");

            }
            
        }



    }

    public void LoadFromFile(){

        _entries.Clear();

        Console.WriteLine("Who's journal do you want to open?");

        string fileName = Console.ReadLine();

        string file = fileName + ".txt";

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
        


    }

}