using System.Diagnostics;
using System.Dynamic;
using System.Runtime;
using System.Xml.Linq;

namespace Develop05;

public class Menu
{
    
    private List<Goal> _loadedGoals = new List<Goal>();

    public void MenuOptions() {
        
        // Console.WriteLine("You have " + GetPoints() + " points.");

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
                SetCompletions();
                break;
            case "6":
                break;
        }
    }

    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter("SaveFile.txt"))
        {
            foreach (var VARIABLE in _loadedGoals) {
                
                outputFile.WriteLine(VARIABLE.SaveOutput());
                
            }
        }
        
        MenuOptions();
    }

    public void Load()
    {
        string filename = "SaveFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

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
        MenuOptions();
    }

    public void CreateGoal()
    {
        
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
                String UI1 = Console.ReadLine();
                Console.WriteLine("What is the description of your goal?");
                String UI2 = Console.ReadLine();
                Console.WriteLine("How many points would you like to assign to this goal?");
                String UI3 = Console.ReadLine();
                
                Eternal eternal = new Eternal(UI1, UI2, Int32.Parse(UI3), -1, 0);
                _loadedGoals.Add(eternal);
                
                break;
            
            case "2":
                
                Console.WriteLine("What is the name of your goal?");
                String UI4 = Console.ReadLine();
                Console.WriteLine("What is the description of your goal?");
                String UI5 = Console.ReadLine();
                Console.WriteLine("How many points would you like to assign to this goal?");
                String UI6 = Console.ReadLine();

                Simple simple = new Simple(UI4, UI5, Int32.Parse(UI6), -1, 0);
                _loadedGoals.Add(simple);
                
                break;
            
            case "3":
                
                Console.WriteLine("What is the name of your goal?");
                String UI11 = Console.ReadLine();
                Console.WriteLine("What is the description of your goal?");
                String UI12 = Console.ReadLine();
                Console.WriteLine("How many points would you like to assign to this goal?");
                String UI13 = Console.ReadLine();
                Console.WriteLine("How many sub-goals would you like to add?");
                String UI14 = Console.ReadLine();
                
                Checklist checklist = new Checklist(UI11, UI12, Int32.Parse(UI13), Int32.Parse(UI14), 0);
                _loadedGoals.Add(checklist);

                break;
            
            case "4":

                Console.WriteLine("What is the name of your goal?");
                String UI7 = Console.ReadLine();
                Console.WriteLine("What is the description of your goal?");
                String UI8 = Console.ReadLine();
                Console.WriteLine("How many points would you like to have removed if this goal is completed? (Use a possitive value)");
                String UI9 = Console.ReadLine();
                
                Vice vice = new Vice(UI7, UI8, Int32.Parse(UI9), -1, 0);

                break;
        }

    }

    public void DisplayAllGoals()
    {

        if (_loadedGoals.Count == 0) {
            Console.WriteLine("No Goals");
            return;
        }

        for (int i = 0; i < _loadedGoals.Count; i++)
        {
            Console.Write(i.ToString() + ". ");
            _loadedGoals[i].Display();
            Console.WriteLine();
        }
    }

    public int GetPoints()
    {
        
        if (_loadedGoals.Count == 0) {
            Console.WriteLine("No Goals");
            return 0;
        }
        
        int tally = 0;

        for (int i = 0; i < _loadedGoals.Count; i++) {

            tally += _loadedGoals[i].GSet_points(-1);

        }
        
        return tally;
    }

    public void SetCompletions()
    {
        
    }
    
}