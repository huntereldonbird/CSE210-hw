using System.Diagnostics;
using System.Dynamic;
using System.Xml.Linq;

namespace Develop05;

public class Menu
{
    
    private List<Goal> _goals;

    public Menu()
    {
        
        Console.WriteLine("You have " + GetPoints() + " points.");

        Console.WriteLine("Menu Options:");
        
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.WriteLine("Select an option from the menu:");
        
    }

    public void Save()
    {
        
    }

    public void Load()
    {
        
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
                
                Eternal eternal = new Eternal(UI1, UI2, Int32.Parse(UI3));
                _goals.Add(eternal);
                
                break;
            
            case "2":
                Console.WriteLine("What is the name of your goal?");
                String UI4 = Console.ReadLine();
                Console.WriteLine("What is the description of your goal?");
                String UI5 = Console.ReadLine();
                Console.WriteLine("How many points would you like to assign to this goal?");
                String UI6 = Console.ReadLine();

                Simple simple = new Simple(UI4, UI5, Int32.Parse(UI6));
                _goals.Add(simple);
                
                break;
            
            case "3":
                
                Console.WriteLine("What is the name of your goal?");
                String UI11 = Console.ReadLine();
                Console.WriteLine("What is the description of your goal?");
                String UI12 = Console.ReadLine();
                Console.WriteLine("How many sub-goals would you like to add?");
                String UI13 = Console.ReadLine();
                
                
                List<Goal> tmpGoals = new List<Goal>();
                for (int i = 0; i < Int32.Parse(UI13); i++)
                {
                    Console.WriteLine("What will be the " + i.ToString() + " Sub-goal?");
                    String tmpInput = Console.ReadLine();
                    ChecklistGoal checklistGoal = new ChecklistGoal(tmpInput);
                    tmpGoals.Add(checklistGoal);
                }
                
                Vice vice = new Vice(UI11, UI12, Int32.Parse(UI13));
                _goals.Add(vice);

                break;
            case "4":

                Console.WriteLine("What is the name of your goal?");
                String UI7 = Console.ReadLine();
                Console.WriteLine("What is the description of your goal?");
                String UI8 = Console.ReadLine();
                Console.WriteLine("How many points would you like to have removed if this goal is completed? (Use a possitive value)");
                String UI9 = Console.ReadLine();
                

                break;
        }

    }

    public int GetPoints()
    {


        return 1;
    }

    public void SetCompletions()
    {
        
    }
    
}