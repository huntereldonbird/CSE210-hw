using System.Text.Json;

namespace FinalProject;

public class FoodTruckProcess {
    
    private Ticket[] _pastTickets;

    private bool closed = false;

    public FoodTruckProcess() {

        _pastTickets = LoadTickets("active.json");
        
        UpdateLoop(4);

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

    public Ticket[] CloseOutTicket(Ticket ticket, Ticket[] active_tickets) {

        Ticket[] newtickets = new Ticket[0];
        
        foreach (Ticket t in active_tickets) {

            if (t != ticket) {

                newtickets.Append(t);

            }

        }

        if (!(_pastTickets.Contains(ticket))) {
            _pastTickets.Append(ticket);
        }
        
        SaveTickets("past.json", _pastTickets);

        return newtickets;
    }



    public void UpdateLoop(int lastnumfryers) { // this is so I can remake the update loop to remove errors
        
        Console.WriteLine("here");
        System.Diagnostics.Debug.WriteLine("I am using debugging");
        
        int rollingfryers = lastnumfryers;
        
        // update the current active tickets,
        // are there any new items that are done cooking that we can mark off the list?
        // are there any tickets that we can remove from the active queue?
        // after we have removed all current menu items from use, how many do we have left
        
        
        Ticket[] active_tickets = LoadTickets("active.json");

        foreach (Ticket ticket in active_tickets) {
            
            // if the ticket is complete, remove it from the array and work on the next one.

            if (ticket.Get_Complted()) {
                active_tickets = CloseOutTicket(ticket, active_tickets);
                continue;
            }

            // For incomplete tickets, we need to check if any menuitems are done cooking...
            
            // first we check if they are already completed, ingore them if they are,
            // then we need to see if they are started, if they are, we need to check if they are done cooking
            
            foreach (var menuitem in ticket.Get_menu_items()) {

                if (!(menuitem.Get_Completed()) || menuitem.Get_if_started()) { // if incomplete

                    if (menuitem.Get_StartTime().AddSeconds(menuitem.Get_cookTime()) >= DateTime.Now) {

                        // if we have been cooking for long enough we are done with the fryer and we can add it back so that we can use it later.
                        
                        menuitem.Set_Completed(true);
                        rollingfryers += 1;
                    }
                }
            }
            
        }
        
        
        
        // Now we need to see how many items we can now begin cooking,
        // given the number of fryers, how many new menu items can we begin cooking with.

        if (rollingfryers > 4) { // puting this here so that I dont screw something up later, hunter
            rollingfryers = 4;
        }

        foreach (var ticket in active_tickets) {

            foreach (var menuitem in ticket.Get_menu_items()) {

                if (!menuitem.Get_Completed() || !menuitem.Get_if_started()) { // if they are incomplete AND they aren't started yet, we should throw them into the fryer

                    if (rollingfryers > 0) { // if we dont have any fryers, we shouldn't cook more.
                        menuitem.StartCooking();
                        rollingfryers -= 1;
                    }
                }
            }
        }
        
        
        
        
        if (!closed) {
            Thread.Sleep(1000);
            UpdateLoop(lastnumfryers);
            
        }
        else {
            
            SaveTickets("past.json", _pastTickets);
            
        }
    }
    
    
    
    
    
}