using System.Text.Json;

namespace FinalProject;
using System;
using System.Text.Json;


// this is the engine of the food truck, it is what keeps track of everything.
public class FoodTruckProcess {

    private bool closed = false;

    public FoodTruckProcess() {

        UpdateLoop(4);

    }

    // save the arrays to "memory"
    public void SaveTickets(String location, Ticket ticket) {
        
        var options = new JsonSerializerOptions();
        options.WriteIndented = true;

        string tjson = JsonSerializer.Serialize<Ticket>(ticket, options);

        File.WriteAllText(location + ticket.Get_orderid().ToString() + ".json", tjson);
        
    }

    
    // used to get tickets from "memory" or to load them from past tickets
    public Ticket[] LoadTickets(String directory) {

        List<Ticket> result = new List<Ticket>();

        var files = Directory.GetFiles(@directory, "*.json");

        foreach (var file in files) {
            Ticket ticket = JsonSerializer.Deserialize<Ticket>(File.ReadAllText(file));
            result.Add(ticket);
        }

        return result.ToArray();
    }

    public void CloseOutTicket(Ticket ticket) {

        SaveTickets("./past/" + ticket.Get_orderid().ToString(), ticket);
        
        File.Delete(@"./tickets/" + ticket.Get_orderid().ToString());

    }



    public void UpdateLoop(int lastnumfryers) { // this is so I can remake the update loop to remove errors
        
        int rollingfryers = lastnumfryers;
        
        // update the current active tickets,
        // are there any new items that are done cooking that we can mark off the list?
        // are there any tickets that we can remove from the active queue?
        // after we have removed all current menu items from use, how many do we have left
        
        
        Ticket[] current_tickets = LoadTickets("./tickets/");

        foreach (Ticket ticket in current_tickets) {

            // if the ticket is complete, remove it from the array and work on the next one.

            if (ticket.Get_Complted()) {
                CloseOutTicket(ticket);
            }

        }

        // For incomplete tickets, we need to check if any menuitems are done cooking...
            
            // first we check if they are already completed, ingore them if they are,
            // then we need to see if they are started, if they are, we need to check if they are done cooking
            
            
            Ticket[] active_tickets = LoadTickets("./tickets/");
            
            foreach (var ticket in active_tickets) {
                
                foreach (var menuitem in ticket.Get_menu_items()) {

                    // we only need to check items that are started, have their time over, and are not considered complteded. then we can get a fryer back from them.
                    //if they are completed, the fryer is already returned, and if they arent started, they aren't important in this step
                    
                    if (!menuitem.Get_Completed() && menuitem.Get_if_started()) { // if incomplete & started already, 

                        if (menuitem.Get_StartTime().AddSeconds(menuitem.Get_cookTime()) > DateTime.Now) { // if cooking is completed

                            menuitem.Set_Completed(true);
                            rollingfryers += 1;

                            // this means that we take the meal out of the fryer and return the number back so we can use it in the next step
                        }
                    }
                }
            }





            // Now we need to see how many items we can now begin cooking,
        // given the number of fryers, how many new menu items can we begin cooking with.

        if (rollingfryers > 4) { // puting this here so that I dont screw something up later, hunter
            rollingfryers = 4;
        }
        
        Console.Write("here btw");

        Ticket[] working_tickets = LoadTickets("./tickets/");

            while (rollingfryers > 0) {

                for (int i = 0; i < working_tickets.Length; i++) {

                    foreach (var mi in working_tickets[i].Get_menu_items()) {
                        
                        if(rollingfryers < 1 ){ return; }

                        if (!mi.Get_Completed()) {
                            
                            if(rollingfryers < 1 ){ return; }

                            if (mi.Get_StartTime().AddSeconds(mi.Get_cookTime()) > DateTime.Now) {

                                rollingfryers -= 1;
                                

                            }
                        }
                    }
                }
            }

            foreach (var ticket in working_tickets) {
                
                SaveTickets("./tickets/", ticket);
                
            }
            
            
            
            
        
        
        
        
        if (!closed) {
            Thread.Sleep(1000);
            UpdateLoop(lastnumfryers);
            
        }
        
    }
    
    
    
    
    
}