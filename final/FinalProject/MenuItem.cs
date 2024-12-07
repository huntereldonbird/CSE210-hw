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

	private String _name;
	
	private DateTime _startTime; // this is set when it is put into a "fryer", hunter


	public void StartCooking() {

		_startTime = DateTime.Now;

	}

	public MenuType GetMenuType() {
		return _menuType;
	}

	public String Display() {

		return "_name";

	}
	
}