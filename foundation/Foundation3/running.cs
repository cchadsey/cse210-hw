using System;

class Running: Activity{
    private double _distance;


    public Running(string date, double length, double distance): base(date, length){
        _distance = distance;
    }
    public override void getSummary(){
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Console.WriteLine($"{base.getDate()} Biking ({base.getLength()})- Distance {getDistance():.##} miles, Speed {getSpeed():.##} mph, Pace: {getPace():.##} min per mile");
    }

    public override double getDistance(){
        return _distance;
    }


    public override double getSpeed(){
        //Speed (mph or kph) = (distance / minutes) * 60
        //Speed = 60 / pace
        double t = getLength();
        double speed = _distance / t;
        return speed;

    }

    public override double getPace(){
        //Pace (min per mile or min per km)= minutes / distance
        //Pace = 60 / speed
        double pace = 60 / getSpeed();
        return pace;

    }
}