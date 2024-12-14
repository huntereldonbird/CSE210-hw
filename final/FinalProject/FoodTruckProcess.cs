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

        var files = Directory.GetFiles(directory, "*.json");

        foreach (var file in files) {
            Ticket ticket = JsonSerializer.Deserialize<Ticket>(File.ReadAllText(file));
            result.Add(ticket);
        }

        return result.ToArray();
    }

    public void CloseOutTicket(Ticket ticket) {

        SaveTickets("./past/" + ticket.Get_orderid().ToString(), ticket);
        
        File.Delete("./tickets/" + ticket.Get_orderid().ToString());

    }



    public void UpdateLoop(int lastnumfryers) { // this is so I can remake the update loop to remove errors

        
        int rollingfryers = lastnumfryers;
       

        // Now we need to see how many items we can now begin cooking,
        // given the number of fryers, how many new menu items can we begin cooking with.

        
        Ticket[] working_tickets = LoadTickets("./tickets/");

        for (int i = 0; i < working_tickets.Length; i++) {

            MenuItem[] menuItems = working_tickets[i].Get_menu_items();

            foreach (var mi in menuItems) {
                
                if(rollingfryers < 0){ continue; }

                if (!mi.Get_if_started()) {
                    
                    mi.StartCooking();
                    rollingfryers -= 1;
                    Console.WriteLine("Started: " + mi.Display());

                }
                
                //Console.Write("No Need to Cook!");
                    
                
            }

        }
        


        foreach (var ticket in working_tickets) {
            
            SaveTickets("./tickets/", ticket);
            
        }
        
        
        
        
        
        if (!closed) {
            Thread.Sleep(1000);
            UpdateLoop(rollingfryers);
            
        }
        
    }
    
    
    
    
    
}