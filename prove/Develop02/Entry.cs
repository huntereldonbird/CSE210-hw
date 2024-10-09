using System;

public class Entry
{
    public int _time;
    public String _name;
    public String _prompt;

    public String _entry;
    public String _mood;

    public String _POTD;

    public void _Display(){
        Console.WriteLine(_time + _name + _prompt + _entry + _mood + _POTD);
    }
    public String GetEntry(){
        return _time + _name + _prompt + _entry + _mood + _POTD;
    }
}