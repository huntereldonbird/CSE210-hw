using System.Data;

namespace FinalProject;

public class KitchenSystem {
    // consider adding ASCII art as a loading animation when an item is being prepared

    private FoodTruck _foodTruck;

    private int _fryers;
    
    public KitchenSystem(FoodTruck foodTruck) {

        _foodTruck = foodTruck;
        
        
        UpdateLoop(4);
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

    
    
    
    // this loop runs regardless of wheter someone has entered it and is looking into it, hunter
    
    public void UpdateLoop(int lastavailablefryers) {

        int availablefryers = lastavailablefryers;
        

        
        
        // this containers the fryer logic, and will keep going until all fryers are in use, hunter
        // if you find something that is in "cooking" then add 1 to i, otherwise ignore it..., hunter
        
        // basically, this function updates the completion status and readds the fryers back if htey are idle, hunter

        Ticket[] tickets = _foodTruck.GetActiveTickets();

        foreach (var t in tickets) {

            // firstly, we should check if any items are completed, and thus can be "removed" from fryers

            foreach (var mi in t.Get_menu_items()) {

                if (!mi.Get_Completed()) { // if incomplete

                    DateTime current = DateTime.Now;

                    if (current >= mi.Get_StartTime().AddSeconds(mi.Get_cookTime())) { // if it has been cooking for enough time
                        
                        mi.Set_Completed(true);
                        availablefryers++;

                    } // if it hasnt been cooking for enough time, the same number of fryers are in use, hunter
                }
            }
        }
        
        
        // this entire section is dedicated to removeing completed tickets btw, hunter

        

        foreach (var ticket in tickets) {

            bool doIremove = true; // guilty until proven innocent...... , hunter

            foreach (var mi in ticket.Get_menu_items()) {

                if (!mi.Get_Completed()) {
                    doIremove = false;
                }
            }


            if (doIremove) {

                _foodTruck.RemoveTicket(ticket); // this removes it
                
            }
        }

        
        
        
        
        

            // after this we should see if we can put anything else in the fryer
            
            Ticket[] updatedTickets = _foodTruck.GetActiveTickets();

            for (int i = availablefryers; i > 0;) {

                foreach (var ticket in tickets) {

                    if (!ticket.Get_Complted()) { // if the ticket is completed already forget about it, hunter
                        
                        foreach (var menuItem in ticket.Get_menu_items()) {

                            if (i < 1) { // just as inssurance so that we dont use our negative first fryer, hunter
                                break;
                            }

                            if (!menuItem.Get_Completed()) { // if the menu item is completed, we can ignore it, hunter
                                
                                menuItem.StartCooking();
                                i--;

                            }
                        }
                    }
                }
            }















        _fryers = availablefryers;    
        Thread.Sleep(1000);
        if (_foodTruck.Closing()) { // if the foodtruck says closing, then the recusion breaks..., hunter
            UpdateLoop(availablefryers);
        }
    }
    
}