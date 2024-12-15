using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace FinalProject;

public class Register {

	private FoodTruck _foodTruck;

	public Register(FoodTruck foodTruck) {

		_foodTruck = foodTruck;

	}

	
	// returns true if valid, false if invalid
	public bool ValidateInput(int i, int j) {

		if (i < 0 || i > (j-1)) {
			Console.WriteLine("Please enter a valid number");
			return false;
		}

		return true;

	}

	// only use this when you are creating a new ticket, hunter
	public void BeginSession() {

		bool active = true;

		Console.Clear();

		Console.WriteLine("Register System:");

		Console.WriteLine("Press any key to start an order.");

		ConsoleKey keyInfo = Console.ReadKey(true).Key;

		if (keyInfo != ConsoleKey.Clear) {

			List<MenuItem> menuItems = new List<MenuItem>();

			while (active) {

				MenuItem menuItem = AddToOrder();

				if (menuItem == null) {
					active = false;
					break;
				}

				menuItems.Add(menuItem);
			}
			
			
			
			Ticket ticket = new Ticket(menuItems.ToArray());
			_foodTruck.NewTicketCreated(ticket);
			
			Console.WriteLine(ticket.Display() + " Total = " + ticket.Get_Total_Price() + "$");

		}

		Console.WriteLine("c : continue, q : quit");

		string userin = Console.ReadLine();

		switch (userin) {
			
			case("c"):
				BeginSession();
				break;
			case("q"):
				Console.Clear();
				break;
		}
	}

public MenuItem AddToOrder(){
			
		
		
		string choice = "";
		// while (validInput) {

			Console.WriteLine("Which item are you adding :");
			
			Console.WriteLine("		1) Entré");
			Console.WriteLine("		2) Side");
			Console.WriteLine("		3) Drink");
			Console.WriteLine("		4) Done");
		
			choice = Console.ReadLine();

			if (!string.IsNullOrEmpty(Convert.ToString(choice))) {
				if (Convert.ToInt32(choice) > 4 || Convert.ToInt32(choice) < 0) {
					Console.WriteLine("Please enter a number from 1 to 4");
					return AddToOrder();
				}
			}
		// }
		
	

		switch (choice) {
			
			case("1"): // if they want entres, iterate over them and display each one of them out. we will keep track of them in an index so when a choice is made we can just grab it, hunter

				List<MenuItem> entres = new List<MenuItem>();

				foreach (var item in _foodTruck.GetExpenditure().GetDictionary()) {
					
					if (item.Key.GetMenuType() == MenuItem.MenuType.entre) {
						entres.Add(item.Key);
					}
					
				}
				
				// this portion is for the display so that the cashier can select the desired menu option from entres, hunter

				for (int i = 0; i < entres.Count; i++) {
					Console.WriteLine("		" + i + ": " + entres[i].Display());
				}
				
				int entre_choice = int.Parse(Console.ReadLine());	
				
				
				if (ValidateInput(entre_choice, entres.Count)) {
					return entres[entre_choice];
				}
				return AddToOrder();
				
			case ("2"):
				List<MenuItem> sides = new List<MenuItem>();

				foreach (var item in _foodTruck.GetExpenditure().GetDictionary()) {
					
					if (item.Key.GetMenuType() == MenuItem.MenuType.side) {
						sides.Add(item.Key);
					}
					
				}

				for (int i = 0; i < sides.Count; i++) {
					Console.WriteLine("		" + i + ": " + sides[i].Display());
				}
				
				int sides_choice = int.Parse(Console.ReadLine());
				if (ValidateInput(sides_choice, sides.Count)) {
					return sides[sides_choice];
				}
				return AddToOrder();
			
			case("3"):
				
				List<MenuItem> drinks = new List<MenuItem>();

				foreach (var item in _foodTruck.GetExpenditure().GetDictionary()) {
					
					if (item.Key.GetMenuType() == MenuItem.MenuType.drink) {
						drinks.Add(item.Key);
					}
					
				}

				for (int i = 0; i < drinks.Count; i++) {
					Console.WriteLine("		" + i + ": " + drinks[i].Display());
				}
				
				int drinks_choice = int.Parse(Console.ReadLine());
				if (ValidateInput(drinks_choice, drinks.Count)) {
					return drinks[drinks_choice];
				}
				return AddToOrder();
			
			case("4"):

				return null;
			
			
		}

		return null;
		
		
	}
	
}