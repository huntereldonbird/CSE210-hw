namespace Foundation1;
using System.Text.Json.Serialization;
public class MenuItemTest {


	public MenuItemTest(MenuType type, int time, float price, DateTime start) {

		_menuType = type;
		_cookTimeinSeconds = time;
		_price = price;
		_startTime = start;

		_Completed = true;

	}
	
	[JsonConstructor]
	public MenuItemTest() {
		
	}
    
	public enum MenuType {
		entre,
		drink,
		side,
	}

	public MenuType _menuType {get; set; } // put this on the actual item with the base.menuType = entre, hunter

	public int _cookTimeinSeconds {get; set; }

	public float _price {get; set; }

	public bool _Completed {get; set; }
	
	public DateTime _startTime {get; set; } // this is set when it is put into a "fryer", hunter
	
}