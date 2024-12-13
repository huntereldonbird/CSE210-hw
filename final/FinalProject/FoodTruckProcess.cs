namespace FinalProject;

public class FoodTruckProcess {

    private Ticket[] _activeTickets;

    private Ticket[] PastTickets;

    private bool closed;


    public void SaveTickets(String location) {
        
        Console.Clear();
        
        String filename = "PastTickets.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            for (int i = 0; i < PastTickets.Length; i++) {
                outputFile.WriteLine(PastTickets[i].SaveOut());
            }
            
        }
        
    }

    public Ticket[] LoadTickets() {

        String filename = "SaveFile.txt";
        String[] lines = System.IO.File.ReadAllLines(filename);

        foreach (String line in lines) {
            String[] parts = line.Split("|");

            String type = parts[0];
            String name = parts[1];
            String description = parts[2];
            int points = Int32.Parse(parts[3]);
            int amount = Int32.Parse(parts[4]);
            int completed = Int32.Parse(parts[5]);


        }

        return null;
    }

    public void CloseOutTicket(Ticket ticket) {

        RemoveTicket(ticket);

        PastTickets.Append(ticket);
        

        closed = true;
    }
    
    public void RemoveTicket(Ticket ticket) {
		
        Ticket[] newarray = new Ticket[0];

        foreach (var thisticket in _activeTickets) {
            if (thisticket != ticket) {

                newarray.Append(thisticket);

            }
        }
		
        _activeTickets = newarray;
        
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