using System;

class Journal
{
    public List<Entry> _entries = [];

    public void _Display(){
        foreach (Entry i in _entries) { i._Display(); }
    }
    
}