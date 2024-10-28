using System;

public class Eternal: Goal{

    public Eternal(string name,string description, int points):base(){
        _shortName = name;
        _description = description;
        _points = points;

    }

    public override int RecordEvent(){
        return _points;

    }

    public override bool IsComplete(){
        return false;

    }

    public override string GetStringRepresentation(){
        string s = $"eternal:{_shortName}%{_description}%{_points}";
        return s;

    }

} 