namespace FinalProject;

public class Expenditure {
	
	
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

	
	
    private void change_value(MenuItem menuItem, int value) {
        
	    DictionaryMenuItem[menuItem] = value;
	    
    }

    
    // this is called when it is selected in the food truck interface, hunter
public void BeginSession(int previousindex) {
        
        int index = previousindex;
        
        Console.Clear();
        
        Console.WriteLine("Kitchen System : ");

        foreach (var ticket in _foodTruck.LoadTickets(Directory "*/past/")) {
            
            Console.WriteLine("-----------------------");
            
            Console.Write(ticket.Get_orderid() + " : ");

            foreach (var mi in ticket.Get_menu_items()) {
                Console.Write("[ ");

                if (!mi.Get_Completed() && mi.Get_if_started()) {
                    
                    Task task1 = new Task(() => {
            
                        Spinner spinner = new Spinner();
            
                    });
                    
                    tasks.Add(task1);
                    
                    task1.Start();

                    Console.Write(mi.Display());


                }
                
                Console.Write("]");
                
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