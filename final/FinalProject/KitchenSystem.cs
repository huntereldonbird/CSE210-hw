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

    private bool kill;
    
    
    // this is the area for the code when someone actually enters the code from the foodtruck menu, hunter
    // Only incude visuals and controls from here please...

    public void BeginSession() {

        kill = false;
        
        
        Task task1 = new Task(() => {
            
            RenderScreen(0);
 
        });
        
        task1.Start();
        
        
        
        ConsoleKey keyInfo = Console.ReadKey(true).Key;

        if (keyInfo != ConsoleKey.Clear) {
                
            kill = true;
                
        }

    }

    public void RenderScreen(int index) {
        
        Console.Clear();
        
        if (kill) {
            return;
            
        }
        
        Console.WriteLine("Kitchen System : Press any key to exit.");

        foreach (var ticket in _foodTruck.LoadTickets("./tickets")) {
            Console.WriteLine("-----------------------");
            
            Console.Write(ticket.Get_orderid() + " : ");
            
            foreach (var mi in ticket.Get_menu_items()) {
                Console.Write("[ ");

                if (!mi.Get_Completed() && mi.Get_if_started()) {
                    

                    Console.Write("[" +AnimationFrames[index % 9] + "] ");
                    
                    Console.Write(mi.Display());

                }
                else if(mi.Get_Completed()){
                    
                    Console.Write("[" + "\u2713" + "] ");
                    Console.Write(mi.Display());
                    
                }
                else {
                    
                    Console.Write("[" + "X" + "] ");
                    Console.Write(mi.Display());
                    
                }
                
                Console.Write("]");
                
            }
            
            
            
        }
        
        Thread.Sleep(1000);
        RenderScreen(index + 1);
        
    }

}