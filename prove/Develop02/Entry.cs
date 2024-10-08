using System;

class Entry
{
    public int _time;
    public String _name;
    public String _prompt;

    public String _entry;

    public void _Display(){
        Console.WriteLine(_time + _name + _prompt + _entry);
    }
    public String GetEntry(){
        return _time + _name + _prompt + _entry;
    }
}