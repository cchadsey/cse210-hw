using System;

class Biking: Activity{
    private double _speed;


    public Biking(string date, double length, double speed): base(date, length){
        _speed = speed;
    }
    public override void getSummary(){
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Console.WriteLine($"{base.getDate()} Biking ({base.getLength()})- Distance {getDistance():.##} miles, Speed {getSpeed():.##} mph, Pace: {getPace():.##} min per mile");

    }

    public override double getDistance(){
        //Distance (km) = swimming laps * 50 / 1000
        //Distance (miles) = swimming laps * 50 / 1000 * 0.62
        double distance = base.getLength() * _speed;
        return distance;


    }

    public override double getSpeed(){
        //Speed (mph or kph) = (distance / minutes) * 60
        //Speed = 60 / pace
        return _speed;
    }

    public override double getPace(){
        //Pace (min per mile or min per km)= minutes / distance
        //Pace = 60 / speed
        double pace = 60/ getSpeed();
        return pace;

    }
}