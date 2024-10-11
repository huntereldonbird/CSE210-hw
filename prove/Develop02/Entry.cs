using System;

public class Entry
{
    public String _time;
    public String _name;
    public String _prompt;

    public String _entry;
    public String _mood;

    public String _POTD;

    public void _Display(){
        Console.WriteLine(_time + "   " + _name);
        Console.WriteLine(_mood);
        Console.WriteLine(_prompt);
        Console.WriteLine(_entry);
    }
    public String GetEntry(){
        return _time + _name + _prompt + _entry + _mood + _POTD;
    }
}