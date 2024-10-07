using System;

class SaveFile
{
    static void _SaveTheCurrnetFile(String FileName, Journal journal){

        using (StreamWriter DumpFile = new StreamWriter(FileName)){

            foreach(Entry e in journal._entries){

                DumpFile.WriteLine(e._time + "|" + e._name + "|" + e._prompt + "|" + e._entry + "|");

            }



        }

    }
}