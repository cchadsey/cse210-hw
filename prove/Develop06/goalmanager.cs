using System;

class GoalManager{
    
    private List<Goal> _goals = new List<Goal>;

    private int _score;

    public GoalManager(){
        _score = 0

    }

    public void Start(){

        string response = "0";
        bool run = true;


        while (run == true){

            switch (option){

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
                    option = "0"
                    break;
                
                case "2":

                    ListGoalNames()
                    option = "0"
                    break;

                case "3":

                    SaveGoals()
                    option = "0"
                    break;
                
                case "4":

                    LoadGoals()
                    option = "0"
                    break;

                case "5":

                    RecordEvent()
                    option = "0"
                    break:

                case "6":
                    run = false;
                    break;

                default:
                    Console.WriteLine("Invalid Input: Please type only the number of your choice, and press enter.");
                    option = "0";
                    break;
            
            }
        
        
        }




    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();

    }

    public void ListGoalNames(){

    }

    public void ListGoalDetails(){

    }

    public void CreateGoal(){

        Console.WriteLine("What type of Goal would you like to make?")
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        string r = Console.ReadLine();
        switch(r):
            case "1":
                Console.WriteLine("What is the name of your goal?");
                string n =  Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?");
                string d = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth?");
                int p = int.Parse(Console.ReadLine());
                Goal g = new Simple(n, d, p);
                break;
            
            case "2":
                Console.WriteLine("What is the name of your goal?");
                string n =  Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?");
                string d = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth?");
                int p = int.Parse(Console.ReadLine());
                Goal g = new Eternal(n, d, p);
                break;
            

        
  


    }

    public void RecordEvent(){

    }

    public void SaveGoals(){

    }

    public void LoadGoals(){

    }


}