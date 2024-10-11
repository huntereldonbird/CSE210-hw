using System;
using System.Runtime.InteropServices;


public class Journal
{
    public List<Entry> _entries = [];

    public void _Display(){
        foreach (Entry i in _entries) { i._Display(); Console.WriteLine(""); }
    }

    public static Entry _CreateNewEntry(String time, String name, String prompt, String entry, String mood, String potd){
        Entry newEntry = new Entry();

        newEntry._time = time;
        newEntry._name = name;
        newEntry._prompt = prompt;
        newEntry._entry = entry;
        newEntry._mood = mood;
        newEntry._POTD = potd;


        return newEntry;
    }

    
}