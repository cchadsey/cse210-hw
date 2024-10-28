using System;
using System.IO.Enumeration;
using System.Net.Security;

class GoalManager{
    
    private List<Goal> _goals = new List<Goal>();

    private int _score;

    public GoalManager(){
        _score = 0;

    }

    public void Start(){

        string response = "0";
        bool run = true;


        while (run == true){

            switch (response){

                case "0":
                    DisplayPlayerInfo();
                    Console.WriteLine("Menu Options:");
                    Console.WriteLine("  1. Create New Goal");
                    Console.WriteLine("  2. List Goals");
                    Console.WriteLine("  3. Save Goals");
                    Console.WriteLine("  4. Load Gaols");
                    Console.WriteLine("  5. Record Event");
                    Console.WriteLine("  6. Quit");
                    Console.WriteLine("Select a choice from the menu: ");
                    response = Console.ReadLine();
                break;

                case "1":

                    CreateGoal();
                    response = "0";
                    break;
                
                case "2":

                    ListGoalNames();
                    response = "0";
                    break;

                case "3":

                    SaveGoals();
                    response = "0";
                    break;
                
                case "4":

                    LoadGoals();
                    response = "0";
                    break;

                case "5":

                    RecordEvent();
                    response = "0";
                    break;

                case "6":
                    run = false;
                    break;

                default:
                    Console.WriteLine("Invalid Input: Please type only the number of your choice, and press enter.");
                    response = "0";
                    break;
            
            }
        
        
        }




    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();

    }

    public void ListGoalNames(){
        foreach (Goal g in _goals){
            g.getDetailsString();
        }

    }

    public void ListGoalDetails(){
        Console.WriteLine("Your goals are:");
        foreach (Goal g in _goals){
            int x = _goals.IndexOf(g) + 1;
            Console.WriteLine($"{x}.");
            g.getDetailsString();
        }

    }

    public void CreateGoal(){

        Console.WriteLine("What type of Goal would you like to make?");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        string r = Console.ReadLine();
        switch(r){

            case "1":
                Console.WriteLine("What is the name of your goal?");
                string ns =  Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?");
                string ds = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth?");
                int ps = int.Parse(Console.ReadLine());
                Goal gs = new Simple(ns, ds, ps);
                break;
            
            case "2":
                Console.WriteLine("What is the name of your goal?");
                string ne =  Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?");
                string de = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth?");
                int pe = int.Parse(Console.ReadLine());
                Goal ge = new Eternal(ne, de, pe);
                break;
            
            case "3":
                Console.WriteLine("What is the name of your goal?");
                string nl =  Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?");
                string dl = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth?");
                int pl = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times do you want to complete this goal for Bonus points?");
                int tl = int.Parse(Console.ReadLine());
                Console.WriteLine("How many bonus points will that be worth?");
                int bl = int.Parse(Console.ReadLine());
                Goal gl = new Checklist(nl, dl, pl, tl, bl);
                _goals.Add(gl);
                break;

            
        }

        
  


    }

    public void RecordEvent(){
        Console.WriteLine("What is the number of the goal would you like to record an event for?");
        ListGoalNames();
        int respond = int.Parse(Console.ReadLine());
        respond -= 1;
        int p = _goals[respond].RecordEvent();
        _score += p;
        Console.WriteLine("Great Job!");


    }

    public void SaveGoals(){
        Console.WriteLine("What name would you like to save these goals under?");
        string fileName = $"{Console.ReadLine()}.txt";
        using (StreamWriter outputfile = new StreamWriter(fileName)){

        
            foreach (Goal g in _goals){
                string e = g.GetStringRepresentation();
                outputfile.WriteLine(e);
                

            }
        }

    }

    public void LoadGoals(){
        _goals.Clear();
        Console.WriteLine("What is the name of the file you'd like to load?");
        string inputname = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(inputname);
            foreach(string line in lines){
                string[] mainParts = line.Split(":");
                switch(mainParts[0]){
                    case "checklist":
                        string[] subpartsl = mainParts[1].Split("%");

                        Goal gl = new Checklist(subpartsl[0], subpartsl[1], int.Parse(subpartsl[2]), int.Parse(subpartsl[3]), int.Parse(subpartsl[4]));
                        _goals.Add(gl);

                        break;
                    
                    case "eternal":
                        string[] subpartse = mainParts[1].Split("%");
                        Goal ge = new Eternal(subpartse[0], subpartse[1], int.Parse(subpartse[2]));
                        _goals.Add(ge);
                        break;

                    case "simple":
                        string[] subpartss = mainParts[1].Split("%");
                        Goal gs = new Eternal(subpartss[0], subpartss[1], int.Parse(subpartss[2]));
                        _goals.Add(gs);
                        break;



            }

            }

            

        }


}