using System;

public class Goal{

    protected string _shortName;

    protected string _description;

    protected int _points;

    public Goal(){}

    public Goal(string name, string description, string points){

    }

    public virtual int RecordEvent(){

        return _points;
    }

    public  virtual bool IsComplete(){
        return false;
    }

    public virtual void getDetailsString(){

        if (IsComplete() == true){
            Console.Write("[X]");
        }else{
            Console.Write("[ ]");
        }
        
        Console.Write($"{_shortName}");
        Console.Write($"({_description})");
        Console.Write($"{_points}pts");

    }

    public virtual string GetStringRepresentation(){
        string s = $"goal:{_shortName}%{_description}%{_points}";
        return s;

    }
}