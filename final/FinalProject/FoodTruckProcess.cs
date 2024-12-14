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
       

<<<<<<< Updated upstream
        foreach (Ticket ticket in current_tickets) {



            // if the ticket is complete, remove it from the array and work on the next one.

            if (ticket.Get_Complted()) {
                CloseOutTicket(ticket);
            }

        }
        
        Console.Write("here4");


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
                            
                            Console.Write("here2");


                            // this means that we take the meal out of the fryer and return the number back so we can use it in the next step
                        }
                    }
                }
            }


            Console.Write("here5");



            // Now we need to see how many items we can now begin cooking,
=======
        // Now we need to see how many items we can now begin cooking,
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
                    if (menuItem.Get_StartTime().AddSeconds(menuItem.Get_cookTime()) <= DateTime.Now) {
                        
                        menuItem.Set_Completed(true);
                        rollingfryers -= 1;
                        Console.Write("here8");


                    }
                    
=======
>>>>>>> Stashed changes
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