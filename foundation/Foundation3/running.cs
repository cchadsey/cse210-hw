using System;

class Running: Activity{
    private int _distance;


    public Running(): base(){

    }
    public override void getSummary(){
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

    }

    public override void getDistance(){
        //Distance (km) = swimming laps * 50 / 1000
        //Distance (miles) = swimming laps * 50 / 1000 * 0.62

    }

    public override void getSpeed(){
        //Speed (mph or kph) = (distance / minutes) * 60
        //Speed = 60 / pace

    }

    public override void getPace(){
        //Pace (min per mile or min per km)= minutes / distance
        //Pace = 60 / speed

    }
}