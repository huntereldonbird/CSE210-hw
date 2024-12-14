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
    public void BeginSession() {
	    
	    
	    
	    
    }
}