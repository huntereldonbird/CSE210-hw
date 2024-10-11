using System;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

public class Program
{

    public Journal currentJournal = new Journal();

    public void Main(){ 

        Console.WriteLine("Write: 1");
        Console.WriteLine("Display: 2");
        Console.WriteLine("Load: 3");
        Console.WriteLine("Save: 4");
        Console.WriteLine("Quit: 5");
        string UserInput = Console.ReadLine();



    }

    public void _Write(){
        Console.Write("What is your name? ");
        String NameInput = Console.ReadLine();

        Console.Write("What is your current mood? ");
        String MoodInput = Console.ReadLine();


        String newPrompt;
        
        

        Console.WriteLine();
        String entry = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        String dateText = theCurrentTime.ToShortDateString();
        


    }
    public void _Display(){
        currentJournal._Display();
    }
    public void _Load(){
        currentJournal = LoadFile._LoadTheCurrentJournal("Journal.txt");
    }
    public void _Save(){
        //SaveFile._SaveTheCurrnetFile("Journal.txt", currentJournal);
    }
    public void _Quite(){
        
    }






}