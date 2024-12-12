namespace FinalProject;
using System.Threading;
using System.Threading.Tasks;

public class FoodTruck {
	
	
	private Expenditure _expenditure;
	private Register _register;
	private KitchenSystem _kitchenSystem;
	
	// this is here temporarily, idk what to do with this really will ask later in class, hunter
	private Ticket[] _tickets;

	private bool _running;
	
	// does all of the logic when the food truck is started, hunter
	public FoodTruck() {

		Task task1 = new Task(() => { _kitchenSystem = new KitchenSystem(this); });
		
		
		_expenditure = new Expenditure();
		_register = new Register(this);
		

		Console.Clear();
		Console.WriteLine("Welcome to the food truck");
		
		Console.WriteLine();
		
		Console.WriteLine("Which system do you want to use.");
		Console.WriteLine("		1: Register");
		Console.WriteLine("		2: Kitchen");
		Console.WriteLine("		3: Expenditures");
		Console.WriteLine("		4: Close up Shop (Quit)");
		
		int userin = int.Parse(Console.ReadLine());

		switch (userin) {
			// start the register system, hunter
			case (1):
				
				_register.BeginUsingRegisterSystem();

				break;
			
			// star the kitchen system
			case (2):

				_kitchenSystem.Enter();
				
				
				break;
			
			
			// start the expenditure system
			case (3):

				Expenditure expenditure = new Expenditure();
				
				break;
			
			case (4):
				break;
		}
		
	}

	
	// starts up the expenditure class and adds all of the values, hunter
	void load_Expenditure_System() {
		
	}

	public Expenditure GetExpenditure() {
		return _expenditure;
	}

	
	// This is where the new tickets are created grab them from here, or import them.
	public void NewTicketCreated(Ticket ticket) {
		_tickets.Append(ticket);
	}

	public Ticket[] GetActiveTickets() {
		
		return _tickets;
		
	}

	public void RemoveTicket(Ticket ticket) { // we need to make sure that when it removes it goes into a completed tickets, or it is saved somehwere else, hunter
		
		Ticket[] newarray = new Ticket[0];

		foreach (var thisticket in _tickets) {
			if (thisticket != ticket) {

				newarray.Append(thisticket);

			}
		}
		
		_tickets = newarray;
		
		
	}

	public bool Closing() {
		return _running;
	}
	
	public void UpdateLoop(int lastavailablefryers) {

        int availablefryers = lastavailablefryers;
        
        Console.WriteLine("Here");
        
        
        // this containers the fryer logic, and will keep going until all fryers are in use, hunter
        // if you find something that is in "cooking" then add 1 to i, otherwise ignore it..., hunter
        
        // basically, this function updates the completion status and readds the fryers back if htey are idle, hunter

        Ticket[] tickets = _foodTruck.GetActiveTickets();

        if (tickets == null) {
            Thread.Sleep(1000);
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