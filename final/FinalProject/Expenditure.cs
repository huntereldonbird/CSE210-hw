namespace FinalProject;

public class Expenditure {
	
	
	public Dictionary<MenuItem, int> DictionaryMenuItem = new Dictionary<MenuItem, int>() {
		
        {new DeepFriedOreos(), 5},
        //{"Snickers", 5},
        //{"Butter", 5},
        //{"Ice Cream", 5},
        //{"Salad", 5},
        //{"Set of Chicken Tenders", 5},
        //{"Water", -1},
        //{"Baja Blast", 5}
        
        // commented everyhing out becuase I couldn't build it sorry, hunter
    };


	public Dictionary<MenuItem, int> GetDictionary() {
		return DictionaryMenuItem;
	}

    private void change_value(string[MenuItem] args) {
        
    }
}