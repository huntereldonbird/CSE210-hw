namespace FinalProject;

public class Register {
	
	private FoodTruck _foodTruck;

	public Register(FoodTruck foodTruck) {
		
		_foodTruck = foodTruck;
		
	}


	public void BeginUsingRegisterSystem() {
		
		Console.Clear();
		
		Console.WriteLine("Register System:");
		
		Console.WriteLine();
		Console.WriteLine("-----------------");
		Console.WriteLine();
		
		Console.WriteLine("Press enter to start an order.");

		ConsoleKey keyInfo = Console.ReadKey(true).Key;
		
		if(keyInfo != ConsoleKey.Clear) {
			
			// this basically repeats itself until the condition is met, ie the person at the register has selected either the cancel, or the completed, hunter

			MenuItem[] order = BuildMenu(null);

			Ticket _ticket = new Ticket(order, 0);
			
			_foodTruck.NewTicketCreated(_ticket);
			
			BeginUsingRegisterSystem();

		}
		
	}

	
	// laststop basiically just is a break condition, if there sint anything left, then you should break the look and return instead of doing more 'recusion', hunter
	public MenuItem[] BuildMenu(MenuItem[] previousItems) {

		
		MenuItem[] newItems = new MenuItem[0];
		if (previousItems != null) {
			newItems = previousItems;
		}
		
		
		MenuItem tmp = AddNewItem();

		if (tmp != null) {
			newItems.Append(tmp);
			return BuildMenu(newItems);
		}

		return newItems;
		
	}

	public MenuItem AddNewItem() {
		Console.Clear();
			
		Console.WriteLine("Which item are you adding :");
			
		Console.WriteLine("		1) Entre");
		Console.WriteLine("		2) Side");
		Console.WriteLine("		3) Drink");
		Console.WriteLine("		4) Done");
		
		int choice = int.Parse(Console.ReadLine());

		switch (choice) {
			
			case(1): // if they want entres, iterate over them and display each one of them out. we will keep track of them in an index so when a choice is made we can just grab it, hunter

				List<MenuItem> entres = new List<MenuItem>();

				foreach (var item in _foodTruck.GetExpenditure().GetDictionary()) {
					if (item.Key.GetMenuType() == MenuItem.MenuType.entre) {
						entres.Add(item.Key);
					}
					
				}
				
				// this portion is for the display so that the cashier can select the desired menu option from entres, hunter

				for (int i = 0; i < entres.Count; i++) {
					Console.WriteLine(entres[i].Display());
				}

				break;
			case (2):
				break;
			
			case(3):

				
				break;
			
			case(4):

				return null;
				break;
			
			
		}

		return null;
	}
	
}