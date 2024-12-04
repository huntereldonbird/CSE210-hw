namespace FinalProject;

public class FoodTruck {

	
	// does all of the logic when the food truck is started, hunter
	public FoodTruck() {

		Console.Clear();
		Console.WriteLine("Welcome to the food truck");
		
		Console.WriteLine();
		
		Console.WriteLine("Which system do you want to use.");
		Console.WriteLine("		1: Register");
		Console.WriteLine("		2: Kitchen");
		Console.WriteLine("		3: Expenditures");
		
		int userin = int.Parse(Console.ReadLine());

		switch (userin) {
			// start the register system, hunter
			case (1):

				break;
			
			// star the kitchen system
			case (2):

				break;
			
			
			// start the expenditure system
			case (3):

				break;
			
		}
		
	}

	
	// starts up the expenditure class and adds all of the values, hunter
	void load_Expenditure_System() {
		
	}
	
	
}