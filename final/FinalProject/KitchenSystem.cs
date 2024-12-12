using System.Data;

namespace FinalProject;

public class KitchenSystem {
    // consider adding ASCII art as a loading animation when an item is being prepared

    private FoodTruck _foodTruck;

    private int _fryers;
    
    public KitchenSystem(FoodTruck foodTruck) {

        _foodTruck = foodTruck;
     
    }

    
    
    // this is the area for the code when someone actually enters the code from the foodtruck menu, hunter
    // Only incude visuals and controls from here please...
    
    public void Enter() {
        
        Console.WriteLine("Current Orders");

        foreach (var ticket in _foodTruck.GetActiveTickets()) {
            
            Console.WriteLine("Ticket : " + ticket.Get_orderid());
            
            // if you wanted to include time to complete the order it would go here btw, hunter
            
            foreach (var mi in ticket.Get_menu_items()) {

                if (!mi.Get_Completed()) {
                    Console.WriteLine(mi.Display());
                    Spinner spinner = new Spinner();
                    spinner.Animate(mi.Get_cookTime());
                } else {
                    Console.WriteLine();
                    Console.Write("⣤");
                }
                
                
                
            }
            
            Console.WriteLine(" ---------- ");
        }
        
        
    }
    
}