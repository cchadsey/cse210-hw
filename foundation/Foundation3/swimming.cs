using System;
using System.IO.Pipes;

class Swimming: Activity{

    private int _laps;


    public Swimming(string date, double length, int laps): base(date, length){
        _laps = laps;

    }
    public override void getSummary(){
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Console.WriteLine($"{base.getDate()} Biking ({base.getLength()})- Distance {getDistance():.##} miles, Speed {getSpeed():.##} mph, Pace: {getPace():.##} min per mile");

    }

    public override double getDistance(){
        //Distance (km) = swimming laps * 50 / 1000
        //Distance (miles) = swimming laps * 50 / 1000 * 0.62
        double i = _laps *50;
        double km = i /1000;
        double mi = km * 0.62;
        return mi;
    }

    public override double getSpeed(){
        //Speed (mph or kph) = (distance / minutes) * 60
        //Speed = 60 / pace

        double dist = getDistance();
        double speed = dist/ base.getLength() *60;
        return speed;
    }

    public override double getPace(){
        //Pace (min per mile or min per km)= minutes / distance
        //Pace = 60 / speed
        double pace = 60/ getSpeed();
        return pace;
    }
}