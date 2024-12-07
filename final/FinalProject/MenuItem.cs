using System.ComponentModel;

namespace FinalProject;

public class MenuItem {

	public enum MenuType {
		entre,
		drink,
		side,
	}
	
	MenuType _menuType; // put this on the actual item with the base.menuType = entre, hunter

	private int _cookTimeinMinutes;
	
	private float _price = 0;

	public void Set_price(float price) {
		_price = price;
	}

	private String _name = "BASE NAME HERE";


	public String Get_name() {
		return _name;
	}

	public void Set_name(String name) {
		_name = name;
	}
	
	private DateTime _startTime; // this is set when it is put into a "fryer", hunter


	public void StartCooking() {

		_startTime = DateTime.Now;

	}

	public MenuType GetMenuType() {
		return _menuType;
	}

	public void Set_menuType(MenuType menuType) {
		_menuType = menuType;
	}

	public String Display() {

		return _name;

	}
	
}