namespace FinalProject;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;

public class FoodTruck {
	
	
	private Expenditure _expenditure;
	private Register _register;
	private KitchenSystem _kitchenSystem;
	

	private bool _running;
	
	// does all of the logic when the food truck is started, hunter
	public FoodTruck() {
		
		_register = new Register(this);
		_kitchenSystem = new KitchenSystem(this);
		_expenditure = new Expenditure();
		
		BeginSession();
		
	}

	public void BeginSession() {
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
				
				_register.BeginSession();
				BeginSession();

				break;
			
			// star the kitchen system
			case (2):

				_kitchenSystem.BeginSession();
				BeginSession();
				
				break;
			
			
			// start the expenditure system
			case (3):

				_expenditure.BeginSession();
				BeginSession();
				
				
				break;
			
			case (4):
				break;
		}
	}
	

	public Expenditure GetExpenditure() {
		return _expenditure;
	}

	
	// This is where the new tickets are created grab them from here, or import them.
	public void NewTicketCreated(Ticket ticket) {

		Ticket[] tmp = LoadTickets("active.json");

		if (tmp != Array.Empty<Ticket>()) {
			tmp = new Ticket[1] {
				ticket
			};
		}
		
		Console.WriteLine(ticket.Get_menu_items()[0].Display());

		tmp.Append(ticket);

		SaveTickets("active.json", tmp);

	}
	
	public Ticket[] LoadTickets(String location) {

		var ticket = File.ReadAllText(location);
        
		if (ticket == String.Empty) {
			return new Ticket[0];
		}
        
		TicketSaveFormat saveFormat = JsonSerializer.Deserialize<TicketSaveFormat>(ticket);

		Ticket[] result = saveFormat.Get();

		return result;
	}
	
	public void SaveTickets(String location, Ticket[] tickets) {
        
		TicketSaveFormat saveFormat = new TicketSaveFormat(tickets);
        
		var options = new JsonSerializerOptions();
		options.WriteIndented = true;

		string tjson = JsonSerializer.Serialize<TicketSaveFormat>(saveFormat, options);

		File.WriteAllText(location, tjson);
        
	}

	public bool Closing() {
		return _running;
	}
	
}