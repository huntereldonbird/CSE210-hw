using System;

class Entry
{
    public int _time;
    public String _name;
    public String _prompt;

    public String _entry;

    public String _Display(){
        Console.WriteLine(_time + _name + _prompt + _entry);
        return _time + _name + _prompt + _entry;
    }
}