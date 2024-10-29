using System;

class Running: Activity{
    private int _distance;


    public Running(): base(){

    }
    public override void getSummary(){
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

    }


    public override int getSpeed(){
        //Speed (mph or kph) = (distance / minutes) * 60
        //Speed = 60 / pace
        int t = getLength();
        int speed = _distance / t;
        return speed;

    }

    public override void getPace(){
        //Pace (min per mile or min per km)= minutes / distance
        //Pace = 60 / speed

    }
}