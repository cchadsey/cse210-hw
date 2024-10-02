using System;

public class Fraction{

    private int _top;
    private int _bottom;

    public void Fraction (){
        _top = 1;
        _bottom = 1;
    };

    public void Fraction(int top){
        _top = top;
        _bottom = 1;

    };
    public void Fraction (int bottom){
        _bottom = bottom;
        _top = 1;

    };

    public int getTop(){
        return _top;
    };
    public int getBottom(){
        return _bottom;
    };

    public void setTop(int top){
        _top = top;
    };
    public void setBottom(int bottom){
        _bottom = bottom;
    };

    public string GetFractionString(){
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }
    public double GetDecimalValue(){
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }
}