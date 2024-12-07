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

			bool finished = false;
			MenuItem[] holdingTicket;

			while (!finished) {

				MenuItem _new = AddNewItem();




			}

		}
		
	}

	public MenuItem AddNewItem() {
		Console.Clear();
			
		Console.WriteLine("Which item are you adding :");
			
		Console.WriteLine("		1) Entre");
		Console.WriteLine("		2) Side");
		Console.WriteLine("		3) Drink");
		Console.WriteLine("		4) Done");
		Console.WriteLine("		5) Cancel");


		return null;
	}
	
}