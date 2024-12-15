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
		
		Console.Clear();

		Ticket[] OldTickets = _foodTruck.LoadTickets("./past/");

		foreach (var ticket in OldTickets) {
			
			Console.WriteLine("-----------------------");
            
			Console.Write(ticket.Get_orderid() + " : ");
            
			foreach (var mi in ticket.Get_menu_items()) {

				Console.Write("[");

				Console.Write(mi.Display());
				
				Console.Write("]");

                
			}
			
			Console.WriteLine();
			
			Console.Write(ticket.Get_Total_Price() + "$.................");
			
			Console.Write(ticket.Get_created());

			Console.WriteLine();

		}
		
		Console.WriteLine("-----------------------");







	}

}