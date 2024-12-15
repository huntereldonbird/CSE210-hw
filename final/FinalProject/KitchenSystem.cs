using System.Data;

namespace FinalProject;

public class KitchenSystem {
    // consider adding ASCII art as a loading animation when an item is being prepared
    
    public String[] AnimationFrames =
        [
        "⣦",
        "⣮",
        "⣴",
        "⣪",
        "⣤",
        "⣥",
        "⣴",
        "⣦",
        "⣤"
        ];

    private FoodTruck _foodTruck;

    private int _fryers;
    
    List<Task> tasks = new List<Task>();
    
    public KitchenSystem(FoodTruck foodTruck) {

        _foodTruck = foodTruck;
     
    }

    
    
    // this is the area for the code when someone actually enters the code from the foodtruck menu, hunter
    // Only incude visuals and controls from here please...

    public void BeginSession(int previousindex) {
        
        int index = previousindex;
        
        Console.Clear();
        
        Console.WriteLine("Kitchen System : ");

        foreach (var ticket in _foodTruck.LoadTickets("./tickets/")) {
            
            Console.WriteLine("-----------------------");
            
            Console.Write(ticket.Get_orderid() + " : ");

            foreach (var mi in ticket.Get_menu_items()) {
                Console.Write("[ ");

                if (!mi.Get_Completed() && mi.Get_if_started()) {
                    
                    Task task1 = new Task(() => {
            
                        Spinner spinner = new Spinner();
            
                    });
                    
                    tasks.Add(task1);
                    
                    task1.Start();

                    Console.Write(mi.Display());


                }
                
                Console.Write("]");
                
            }
            
            //maybe here???
            
            Console.WriteLine();

            
            
        }
        
        Console.WriteLine("-----------------------");

        Console.WriteLine("c : refresh, q : quit");

        string userin = Console.ReadLine();

        switch (userin) {
			
            case("c"):
                BeginSession(index);
                break;
            case("q"):
                Console.Clear();
                break;
        }
    }   

}