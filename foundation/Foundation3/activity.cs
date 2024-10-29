using System;

class Activity{

    private DateTime _date;

    private int _length;

    
    public Activity(){

    }

    public virtual void getSummary(){
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }

    public int getLength(){
        return _length;
    }

    public virtual void getDistance(){

        //Distance (km) = swimming laps * 50 / 1000
        //Distance (miles) = swimming laps * 50 / 1000 * 0.62

    }

    public virtual int getSpeed(){
        //Speed (mph or kph) = (distance / minutes) * 60
        //Speed = 60 / pace
        
        return 000;
    }

    public virtual void getPace(){
        //Pace (min per mile or min per km)= minutes / distance
        //Pace = 60 / speed

    }
    
}