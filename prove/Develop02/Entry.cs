using System;

class Entry
{
    public String _entry;
    public String _name;
    public String _prompt;
    public int _time;

    public String _Display(){
        Console.WriteLine(_name + _time + _prompt + _entry);
        return _name + _time + _prompt + _entry;
    }
}