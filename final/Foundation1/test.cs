using System.Text.Json.Serialization;

namespace Foundation1;

public class test {
	
	
	public test(MenuItemTest[] mi, int id, String name, bool c, DateTime date) {

		_menuItems = mi;
		_orderid = id;
		OrderName = name;
		_created = date;
		_complted = c;

	}
	
	[JsonConstructor]
	public test() {
		
	}
	
	

    public MenuItemTest[] _menuItems {get; set; }
    
    public int _orderid {get; set; }
    
    public String OrderName {get; set; } // for later if we want to..., hutner

    public DateTime _created {get; set; }

    public bool _complted {get; set; }
    
	    
}