using System;

class Simple: Goal{

    private bool _isComplete;

    public Simple(string name, string description, int points):base(){
        _shortName = name;
        _description = description;
        _points = points;

    }

    public override int RecordEvent(){
        _isComplete = true;
        return _points;

    }

    public override bool IsComplete(){
        
        return _isComplete;

    }

    public override string GetStringRepresentation(){
        string s = $"simple:{_shortName}%{_description}%{_points}";
        return s;
        
    }
}