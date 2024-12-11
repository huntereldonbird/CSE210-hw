using System.Data;

namespace FinalProject;

public class KitchenSystem {
    // consider adding ASCII art as a loading animation when an item is being prepared

    private FoodTruck _foodTruck;
    
    public KitchenSystem(FoodTruck foodTruck) {

        _foodTruck = foodTruck;
        
        
        UpdateLoop();
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
                }
                
                
                
            }
            
            Console.WriteLine(" ---------- ");
        }
        
        
    }

    
    
    
    // this loop runs regardless of wheter someone has entered it and is looking into it, hunter
    
    public void UpdateLoop() {

        int _numFryers = 4;

        
        
        // this containers the fryer logic, and will keep going until all fryers are in use, hunter
        // if you find something that is in "cooking" then add 1 to i, otherwise ignore it..., hunter
        
        for (int i = 0; i < _numFryers;) {

            Ticket[] tickets = _foodTruck.GetActiveTickets();

            foreach (var t in tickets) {

                
                // if the ticket is completed it shouldn't be in the list in the first place, hunter
                if (t.Get_Complted()) {
                    i++;
                    
                }

                else {
                    foreach (var mi in t.Get_menu_items()) {

                        if (!mi.Get_Completed()) { // if incomplete
                            
                            
                            mi.StartCooking();



                            i++; // this fryer is in use ( or it is now), hunter

                        }

                    }
                }
                
                
                
            }

            


            i++;
        }
        
        
        
        
        
        Thread.Sleep(1000);
        UpdateLoop();

    }
    
}