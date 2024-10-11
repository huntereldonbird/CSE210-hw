using System;

public class RunningProcess{
    public void RunningProgram(Journal currentJournal){ 

        bool ProcessKill = false;

        Console.WriteLine("Write: 1");
        Console.WriteLine("Display: 2");
        Console.WriteLine("Load: 3");
        Console.WriteLine("Save: 4");
        Console.WriteLine("Quit: 5");
        string UserInput = Console.ReadLine();


        switch(Int32.Parse(UserInput)){
            case 1:
                currentJournal = _Write(currentJournal);
                break;
            case 2:
                _Display(currentJournal);
                break;
            case 3:
                Console.Write("what is the name of the journal file? ");
                String Jname = Console.ReadLine();
                String JFileName = Jname + ".txt";

                currentJournal = _Load(JFileName);
                break;
            case 4:
            Console.Write("what is the name of the journal file? ");
                String JSaveName = Console.ReadLine();
                String JFileNameSave = JSaveName + ".txt";

                _Save(currentJournal, JFileNameSave);
                break;
            case 5: 
                ProcessKill = _Quit();
                break;
            
        }


        if(ProcessKill){ return; }
        RunningProgram(currentJournal);

    }

    public Journal _Write(Journal journal){


        Console.Write("What is your name? ");
        String NameInput = Console.ReadLine();

        Console.Write("What is your current mood? ");
        String MoodInput = Console.ReadLine();


        String newPrompt = Prompt.GetRandomPrompt();
        Console.WriteLine(newPrompt);
        String entryInput = Console.ReadLine();

        String dateRN = DateTime.Now.ToString("h:mm:ss tt");
        

        Console.Write("Do you have a photo for the day?");
        string POTDinput = Console.ReadLine();


        Entry newEntry = Journal._CreateNewEntry(dateRN, NameInput, newPrompt, entryInput, MoodInput, POTDinput);

        journal._entries.Add(newEntry);

        return journal;

    }
    public void _Display(Journal journal){
        journal._Display();

        // this just gives it some spacing....
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
    }
    public Journal _Load(String FN){
        return LoadFile._LoadTheCurrentJournal(FN);
    }
    public bool _Save(Journal journal, String FN){
        return SaveFile._SaveTheCurrentFile(FN, journal);
    }
    public bool _Quit(){
        return true;
    }






}