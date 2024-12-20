using System.Diagnostics;
using System.Dynamic;
using System.Runtime;
using System.Xml.Linq;

namespace Develop05;

public class Menu
{
    
    // before you even look through my code, please know that I did this at like midnight
    // and was really uninspired, so I basically just kept throwing stuff together until
    // I could get it to work as opposed to planning out stuff, Hunter
    
    private List<Goal> _loadedGoals = new List<Goal>();

    public void MenuOptions() {

        Console.WriteLine("Menu Options:");
        
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.Write("Select an option from the menu: ");
        
        String userin = Console.ReadLine();
        
        switch (userin)
        {
            case "1":
                CreateGoal();
                break;
            case "2":
                DisplayAllGoals();
                break;
            case "3":
                Save();
                break;
            case "4":
                Load();
                break;
            case "5":
                RecordEvent();
                break;
            case "6":

                    return;
                break;
            case "7":

                foreach (var VARIABLE in _loadedGoals) {
                    Console.WriteLine(VARIABLE.GSet_name(null));
                }
                
                break;
        }
        
        MenuOptions();
    }

    public void Save() {
        
        Console.Clear();
        
        String filename = "SaveFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            for (int i = 0; i < _loadedGoals.Count; i++) {
                outputFile.WriteLine(_loadedGoals[i].SaveOutput());
            }
        }
    }

    public void Load()
    {
        
        Console.Clear();
        
        String filename = "SaveFile.txt";
        String[] lines = System.IO.File.ReadAllLines(filename);

        foreach (String line in lines)
        {
            String[] parts = line.Split("|");

            String type = parts[0];
            String name = parts[1];
            String description = parts[2];
            int points = Int32.Parse(parts[3]);
            int amount = Int32.Parse(parts[4]);
            int completed = Int32.Parse(parts[5]);

            if (type == "Checklist") {
                Checklist goal = new Checklist(name, description, points, amount, completed);
                _loadedGoals.Add(goal);
            }
            if (type == "Eternal") {
                Eternal goal = new Eternal(name, description, points, amount, completed);
                _loadedGoals.Add(goal);
            }
            if (type == "Vice") {
                Vice goal = new Vice(name, description, points, amount, completed);
                _loadedGoals.Add(goal);
            }
            if (type == "Simple") {
                Simple goal = new Simple(name, description, points, amount, completed);
                _loadedGoals.Add(goal);
            }
            
        }
    }

    public void CreateGoal()
    {
        
        Console.Clear();
        
        Console.WriteLine("What goal would you like to add?");
        Console.WriteLine("1) Eternal Goal");
        Console.WriteLine("2) Simple Goal");
        Console.WriteLine("3) Checklist Goal");
        Console.WriteLine("4) Vice Goal");

        String UserInput = Console.ReadLine();

        switch (UserInput)
        {
            
            case "1":
                
                Console.WriteLine("What is the name of your goal?");
                String ui1 = Console.ReadLine();
                Console.WriteLine("What is the description of your goal?");
                String ui2 = Console.ReadLine();
                Console.WriteLine("How many points would you like to assign to this goal?");
                String ui3 = Console.ReadLine();
                
                Eternal eternal = new Eternal(ui1, ui2, Int32.Parse(ui3), 1, 0);
                _loadedGoals.Add(eternal);
                
                break;
            
            case "2":
                
                Console.WriteLine("What is the name of your goal?");
                String ui4 = Console.ReadLine();
                Console.WriteLine("What is the description of your goal?");
                String ui5 = Console.ReadLine();
                Console.WriteLine("How many points would you like to assign to this goal?");
                String ui6 = Console.ReadLine();

                Simple simple = new Simple(ui4, ui5, Int32.Parse(ui6), 1, 0);
                _loadedGoals.Add(simple);
                
                break;
            
            case "3":
                
                Console.WriteLine("What is the name of your goal?");
                String ui11 = Console.ReadLine();
                Console.WriteLine("What is the description of your goal?");
                String ui12 = Console.ReadLine();
                Console.WriteLine("How many points would you like to assign to this goal?");
                String ui13 = Console.ReadLine();
                Console.WriteLine("How many sub-goals would you like to add?");
                String ui14 = Console.ReadLine();
                
                Checklist checklist = new Checklist(ui11, ui12, Int32.Parse(ui13), Int32.Parse(ui14), 0);
                _loadedGoals.Add(checklist);

                break;
            
            case "4":

                Console.WriteLine("What is the name of your goal?");
                String ui7 = Console.ReadLine();
                Console.WriteLine("What is the description of your goal?");
                String ui8 = Console.ReadLine();
                Console.WriteLine("How many points would you like to have removed if this goal is completed? (Use a possitive value)");
                String ui9 = Console.ReadLine();
                
                Vice vice = new Vice(ui7, ui8, Int32.Parse(ui9), 1, 0);
                _loadedGoals.Add(vice);
                break;
        }
    }

    public void DisplayAllGoals()
    {
        Console.Clear();
        
        Console.WriteLine("All Loaded Goals:");

        Console.WriteLine();

        if (_loadedGoals.Count == 0) {
            return;
        }

        for (int i = 0; i < _loadedGoals.Count; i++)
        {
            Console.Write("    ");
            Console.Write(i.ToString() + ". ");
            _loadedGoals[i].Display();
            Console.WriteLine();
        }
        Console.WriteLine();
        
        Console.WriteLine("----- You have " + GetPoints() + " points -----");
        Console.WriteLine();
    }

    public int GetPoints()
    {
        
        if (_loadedGoals.Count == 0) {
            Console.WriteLine("No Goals");
            return 0;
        }
        
        int tally = 0;

        foreach (Goal goal in _loadedGoals) {

            if (goal.ConsideredComplete()) {
                tally += goal.WhenCompletedPoints();
            }
            
        }
        
        return tally;
    }

    public void RecordEvent()
    {
        
        Console.Clear();
        
        Console.WriteLine("Which event have you completed?");
        Console.WriteLine();
        
        if (_loadedGoals.Count == 0) {
            return;
        }

        for (int i = 0; i <= _loadedGoals.Count; i++)
        {

            if (i == _loadedGoals.Count) {
                
                Console.Write("Select : ");
                
                int userin = Int32.Parse(Console.ReadLine());

                
                // yes I know that this is really funky btw, but it works, Hunter
                int tmp = _loadedGoals[userin].GSet_completed(_loadedGoals[userin].GSet_completed(-1) + 1);
                
                

            }
            else {
                Console.Write("    ");
                Console.Write(i.ToString() + ". ");
                _loadedGoals[i].Display();
                Console.WriteLine();

            }
        }
        
        
        Console.WriteLine();
        
        
        
        
        
        
        
    }
    
}