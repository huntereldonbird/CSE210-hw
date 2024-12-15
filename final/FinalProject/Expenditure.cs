namespace FinalProject;

public class Expenditure {
	
	FoodTruck _foodTruck;
	
	
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


	public Dictionary<MenuItem, int> GetDictionary() {
		
		return DictionaryMenuItem;
		
	}

	private FoodTruck _foodtruck;
	
    private void change_value(MenuItem menuItem, int value) {
        
	    DictionaryMenuItem[menuItem] = value;
	    
    }
	public Expenditure(FoodTruck foodTruck) {

        _foodTruck = foodTruck;
     
    }

    
    // this is called when it is selected in the food truck interface, hunter
public void BeginSession(int previousindex) {
        
        int index = previousindex;
        
        Console.Clear();
        
        Console.WriteLine("Expenditure System : ");

        foreach (var ticket in _foodTruck.LoadTickets("./past/")) {
            
            Console.WriteLine("-----------------------");
            
            Console.Write(ticket.Get_orderid() + " : ");

            foreach (var mi in ticket.Get_menu_items()) {
                
            }
                        
            Console.WriteLine();

            
            
        }
        
        Console.WriteLine("-----------------------");

        Console.WriteLine("c : refresh, q : quit");

        string userin = Console.ReadLine();

        switch (userin) {
			
            case("c"):
                BeginSession(index);
                break;
            case("q"):
                Console.Clear();
                break;
        }
    }   
}