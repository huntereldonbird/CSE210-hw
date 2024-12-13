using System.Text.Json;

namespace FinalProject;

public class FoodTruckProcess {

    private Ticket[] _activeTickets;

    private Ticket[] _pastTickets;

    private bool closed;

    public FoodTruckProcess() {

        _pastTickets = LoadTickets("active.json");
        _activeTickets = LoadTickets("active.json");

    }

    // save the arrays to "memory"
    public void SaveTickets(String location, Ticket[] tickets) {
        
        var options = new JsonSerializerOptions();
        options.WriteIndented = true;

        string tjson = JsonSerializer.Serialize<Ticket[]>(tickets, options);

        File.WriteAllText(location, tjson);
        
    }

    
    // used to get tickets from "memory" or to load them from past tickets
    public Ticket[] LoadTickets(String location) {

        var ticket = File.ReadAllText(location);
        
        Ticket[] result = JsonSerializer.Deserialize<Ticket[]>(ticket);

        return result;
    }

    public void CloseOutTicket(Ticket ticket) {

        Ticket[] newarray = new Ticket[0];

        foreach (var thisticket in _activeTickets) {
            if (thisticket != ticket) {

                newarray.Append(thisticket);

            }
        }
		
        _activeTickets = newarray;
        
        _pastTickets.Append(ticket);
        
        SaveTickets();
        

        closed = true;
    }



    public void UpdateLoop2(int lastnumfryers) {
        
        
        
        
        
        
        
        
        
        
        
        if (!closed) {
            UpdateLoop2(lastnumfryers);
        }
    }
    
    
    public void UpdateLoop(int lastavailablefryers) {

        int availablefryers = lastavailablefryers;
        
        Console.WriteLine("Here");
        
        
        // this containers the fryer logic, and will keep going until all fryers are in use, hunter
        // if you find something that is in "cooking" then add 1 to i, otherwise ignore it..., hunter
        
        // basically, this function updates the completion status and readds the fryers back if htey are idle, hunter
        

        Ticket[] tickets = LoadTickets();

        if (tickets == null) {
            Thread.Sleep(10000);
            UpdateLoop(availablefryers);
            return;
        }

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

                RemoveTicket(ticket); // this removes it
                
            }
        }

        
        
        
        
        

            // after this we should see if we can put anything else in the fryer

            Ticket[] updatedTickets = LoadTickets();

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

            
        //_fryers = availablefryers;    
        
        
        Thread.Sleep(1000);
        if (!closed) { // if the foodtruck says closing, then the recusion breaks..., hunter
            UpdateLoop(availablefryers);
        }
    }
    
    
    
    
    
}