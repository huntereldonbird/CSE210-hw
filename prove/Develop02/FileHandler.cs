using System;

class SaveFile
{
    public static void _SaveTheCurrnetFile(String FileName, Journal journal){

        using (StreamWriter DumpFile = new StreamWriter(FileName)){

            foreach(Entry e in journal._entries){

                DumpFile.WriteLine(e._time + "|" + e._name + "|" + e._prompt + "|" + e._entry + "|");

            }
        }
    }
}

public class LoadFile{

    public static Journal LoadTheCurrentJournal(String FileName){
        Journal loaded = new Journal();

        string[] lines = System.IO.File.ReadAllLines(FileName);

        foreach ( string line in lines){
            string[] parts = line.Split("|");

            Entry Ent = new Entry();
            
            Ent._time = Int32.Parse(parts[0]);
            Ent._name = parts[1];
            Ent._prompt = parts[2];
            Ent._entry = parts[3];

            
            //add this to the current "loaded" list of entries stored into the journal entries,
            //Also call this from the program.cs file, dont use it here, it has a return.

            loaded._entries.Add(Ent);
        }


        return loaded;
    }
}