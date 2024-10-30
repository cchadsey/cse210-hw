using System;

class Activity{

    private string _date;

    private double _length;

    
    public Activity(string date, double length){
        _date = date;
        _length = length;

    }

    public virtual void getSummary(){
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }

    public double getLength(){
        return _length;
    }
    public string getDate(){
        return _date;
    }

    public virtual double getDistance(){

        //Distance (km) = swimming laps * 50 / 1000
        //Distance (miles) = swimming laps * 50 / 1000 * 0.62
        return 000;
    }

    public virtual double getSpeed(){
        //Speed (mph or kph) = (distance / minutes) * 60
        //Speed = 60 / pace
        
        return 000;
    }

    public virtual double getPace(){
        //Pace (min per mile or min per km)= minutes / distance
        //Pace = 60 / speed

        return 000;
    }
    
}