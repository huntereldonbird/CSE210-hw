namespace FinalProject;

using System.Text.Json;




public class Stock {
	
	
	FoodTruck truck;
	
	
	public Dictionary<MenuItem, int> DictionaryMenuItem = new Dictionary<MenuItem, int>() {
		
		{new BajaBlast(), 5},
		{new DeepFriedButter(), 5},
		{new DeepFriedChickenTenders(), 5},
		{new DeepFriedIceCream(), 5},
		{new DeepFriedOreos(), 5},
		{new DeepFriedSnickers(), 5},
		{new MicrowavedSalad(), 5},
		{new Water(), 5},
		
	};

	public Stock(FoodTruck Truck) {
		DictionaryMenuItem = LoadStock();
		truck = Truck;
	}
	
	public Dictionary<MenuItem, int> LoadStock() {
		
		Dictionary<MenuItem, int> result = JsonSerializer.Deserialize<Dictionary<MenuItem, int>>(File.ReadAllText("./stock/stock.json"));


		return result;
	}

	public Dictionary<MenuItem, int> HowMuchHaveWeUsed() {

		Dictionary<MenuItem, int> result = new Dictionary<MenuItem, int>() {
			{ new BajaBlast(), 0 },
			{ new DeepFriedButter(), 0 },
			{ new DeepFriedChickenTenders(), 0 },
			{ new DeepFriedIceCream(), 0 },
			{ new DeepFriedOreos(), 0 },
			{ new DeepFriedSnickers(), 0 },
			{ new MicrowavedSalad(), 0 },
			{ new Water(), 0 },
		};

		foreach (var ticket in truck.LoadTickets("./tickets/")) {

			if (ticket.GetType() == typeof(BajaBlast)) {
				result[new BajaBlast()]++;
			}
			if (ticket.GetType() == typeof(DeepFriedButter)) {
				result[new BajaBlast()]++;

			}
			if (ticket.GetType() == typeof(DeepFriedChickenTenders)) {
				result[new BajaBlast()]++;

			}
			if (ticket.GetType() == typeof(DeepFriedIceCream)) {
				result[new BajaBlast()]++;

			}
			if (ticket.GetType() == typeof(DeepFriedOreos)) {
				result[new BajaBlast()]++;

			}
			if (ticket.GetType() == typeof(DeepFriedSnickers)) {
				result[new BajaBlast()]++;

			}
			if (ticket.GetType() == typeof(MicrowavedSalad)) {
				result[new BajaBlast()]++;

			}
			if (ticket.GetType() == typeof(Water)) {
				result[new BajaBlast()]++;

			}
		}




		return result;
	}
	
	
	
}