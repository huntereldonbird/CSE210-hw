using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinalProject;

public class MenuItem {

	public enum MenuType {
		entre,
		drink,
		side,
	}
	
	
	// FOR GIBBONS/AMMON, I sadly needed to include the default getters and setters for the JSon serializer
	// otherwise I used the getters and setters that I had made, hunter

	MenuType _menuType { get; set; } // put this on the actual item with the base.menuType = entre, hunter

	public int _cookTimeinSeconds { get; set; }

	public float _price { get; set; }

	public bool _completed { get; set; }
	
	public DateTime _startTime { get; set; } // this is set when it is put into a "fryer", hunter
	
	public bool _started { get; set; } // this is here bcause i was too lazy to find a better way of doing this, hunter
	
	public String _name { get; set; }

	
	[JsonConstructor]
	public MenuItem() {
		
	}

	


	public void Set_Completed(bool b) {
		_completed = b;
	}
	public bool Get_Completed() {
		return _completed;
	}
	public void Set_price(float price) {
		_price = price;
	}

	public void Set_name(String name) {
		_name = name;
	}

	public void Set_cookTime(int time) {
		_cookTimeinSeconds = time;
	}

	public int Get_cookTime() {
		return _cookTimeinSeconds;
	}

	public bool Get_if_started() {
		return _started;
	}
	public void StartCooking() {

		_startTime = DateTime.Now;
		_started = true;

	}
	public DateTime Get_StartTime() {
		return _startTime;
	}

	public MenuType GetMenuType() {
		return _menuType;
	}

	public void Set_menuType(MenuType menuType) {
		_menuType = menuType;
	}
	
	// for display purposes
	public String Display() {

		return _name;

	}
	
}