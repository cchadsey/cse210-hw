using System;

public class Goal{

    protected string _shortName;

    protected string _description;

    protected string _points;

    public Goal(string name, string description, string points){

    }

    public virtual void RecordEvent(){

    }

    public virtual bool IsComplete(){

    }

    public virtual string getDetailsString(){

    }

    public virtual string GetStringRepresentation(){

    }
}