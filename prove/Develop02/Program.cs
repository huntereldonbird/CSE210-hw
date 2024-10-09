using System;

class Program
{
    static void Main(string[] args)
    {
        Journal loaded = LoadFile.LoadTheCurrentJournal("Test.txt");
    }
    Journal jl = LoadFile.LoadTheCurrentJournal("test.txt");
}