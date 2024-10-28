using System;


class Checklist: Goal{
    private int _amountCompleted;

    private int _target;

    private int _bonus;

    public Checklist(string name,string description,int points,int target,int bonus): base() {
        _shortName = name;
        _description = description;
        _points = points;
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent(){
        int total = _points;
        _amountCompleted += 1;
        if (IsComplete() == true){
            total += _bonus;
        }
        return total;

    }

    public override bool IsComplete(){
        bool complete = false;
        if (_amountCompleted == _target){
            complete = true;   
        }
        return complete;

    }

    public override void getDetailsString(){
        Console.Write($"{_shortName}");
        Console.Write($"({_description})");
        Console.Write($"{_points}pts");
        Console.Write($"{_amountCompleted}/{_target}");
        Console.Write($"{_bonus}Bonus Points for full completion.");
    }

    public override string GetStringRepresentation(){
        string s = $"checklist:{_shortName}%{_description}%{_points}%{_target}%{_bonus}";
        return s;

    }


}