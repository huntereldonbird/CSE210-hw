using System;
using System.Security.Cryptography.X509Certificates;

public class SaveFile
{
    public static void _SaveTheCurrentFile(String FileName, Journal journal){

        using (StreamWriter DumpFile = new StreamWriter(FileName)){

            foreach(Entry e in journal._entries){

                DumpFile.WriteLine(e._time + "|" + e._name + "|" + e._prompt + "|" + e._entry + "|" + e._mood + "|" + e._POTD + "|");

            }
        }
    }
}

public class LoadFile{

    public static Journal _LoadTheCurrentJournal(String FileName){
        Journal loaded = new Journal();

        string[] lines = System.IO.File.ReadAllLines(FileName);
        
        foreach ( string line in lines){
            string[] parts = line.Split("|");

            Entry Ent = new Entry();
            
            Ent._time = parts[0];
            Ent._name = parts[1];
            Ent._prompt = parts[2];
            Ent._entry = parts[3];
            Ent._mood = parts[4];
            Ent._POTD = parts[5];

            
            //add this to the current "loaded" list of entries stored into the journal entries,
            //Also call this from the program.cs file, dont use it here, it has a return.

            loaded._entries.Add(Ent);
        }


        return loaded;
    }
}