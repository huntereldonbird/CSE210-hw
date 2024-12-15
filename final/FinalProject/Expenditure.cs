namespace FinalProject;

public class Expenditure {

	FoodTruck _foodTruck;

	public Dictionary<MenuItem, int> DictionaryMenuItem = new Dictionary<MenuItem, int>() {

		{ new BajaBlast(), 5 },
		{ new DeepFriedButter(), 5 },
		{ new DeepFriedChickenTenders(), 5 },
		{ new DeepFriedIceCream(), 5 },
		{ new DeepFriedOreos(), 5 },
		{ new DeepFriedSnickers(), 5 },
		{ new MicrowavedSalad(), 5 },
		{ new Water(), 5 },

	};


	public Dictionary<MenuItem, int> GetDictionary() {

		return DictionaryMenuItem;

	}

	public Expenditure(FoodTruck foodTruck) {

		_foodTruck = foodTruck;

	}

	public void BeginSession() {

		double RunnintTotal = 0;
		double RunningCost = 0;
		int tally = 0;
		
		Console.Clear();

		Ticket[] OldTickets = _foodTruck.LoadTickets("./past/");

		foreach (var ticket in OldTickets) {

			tally++;
			
			
			Console.WriteLine("-----------------------");
			
            
			Console.Write(ticket.Get_orderid() + " : ");
            
			foreach (var mi in ticket.Get_menu_items()) {

				Console.Write("[");

				Console.Write(mi.Display());
				
				Console.Write("]");

                
			}
			
			Console.WriteLine();
			
			Console.Write(ticket.Get_Total_Price() + "$.................");
			
			RunnintTotal += ticket.Get_Total_Price();
			RunningCost += ticket.Get_Total_Cost();
			
			Console.Write(ticket.Get_created());
			
			Console.WriteLine();
			
			Console.WriteLine("-----------------------");

			Console.WriteLine();

		}
		
		Console.WriteLine("");
		
		Console.WriteLine("-------------------------------------------------------------------------------------");

		Console.WriteLine("Total Revenue : " + RunnintTotal + "$" + "		Total Expences : " + RunningCost + "$" + "		Profit : " + (RunnintTotal - RunningCost) + "$");

		Console.WriteLine("-------------------------------------------------------------------------------------");
		
		Console.WriteLine("Press any key to continue...");



		ConsoleKey keyInfo = Console.ReadKey(true).Key;

		if (keyInfo != ConsoleKey.Clear) {
                
			
                
		}




	}

}