namespace FinalProject;

public class FoodTruck {
	
	
	private Expenditure _expenditure;
	private Register _register;
	private KitchenSystem _kitchenSystem;
	
	// this is here temporarily, idk what to do with this really will ask later in class, hunter
	private Ticket[] _tickets;

	
	// does all of the logic when the food truck is started, hunter
	public FoodTruck() {
		
		_expenditure = new Expenditure();
		_register = new Register(this);
		_kitchenSystem = new KitchenSystem();
		

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

				KitchenSystem kitchenSystem = new KitchenSystem();
				
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

	public void NewTicketCreated(Ticket ticket) {
		
	}
}