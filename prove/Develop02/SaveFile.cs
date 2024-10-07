using System;

class SaveFile
{

    static void Main(string[] args)
    {

        String fileName = "JournalSaves.txt";

        
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
        outputFile.WriteLine();
        
        string color = "Blue";
        outputFile.WriteLine($"My favorite color is {color}");
        }

    }
}