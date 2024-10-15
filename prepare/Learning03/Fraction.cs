using System;
using System.Dynamic;

public class Fraction
{
    private int _top;
    private int _bottom;
    

    public int GetTop(){
        return _top;
    }
    public int GetBottom(){
        return _bottom;
    }
    public bool SetTop(int t){
        _top = t;
        return true;
    }
    public bool SetBottom(int b){
        _bottom = b;
        return true;
    }

    public void Construct(int t, int b){
        _top = t;
        _bottom = b;
    }

    public String GetFractionalString(){
        return _top.ToString() + "/" + _bottom.ToString();
    }
    public float GetDecimalValue(){
        return _top/_bottom;
    }


}