using System;

public class Job{
    public String _company;
    public String _jobtitle;
    public int _startyear;
    public int _endyear;

    public void Display(){

        Console.WriteLine(_jobtitle + " (" + _company + ") " + _startyear.ToString() + "-" + _endyear.ToString());

    }
}