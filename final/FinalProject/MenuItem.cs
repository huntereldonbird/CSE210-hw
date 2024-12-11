using System.ComponentModel;

namespace FinalProject;

public class MenuItem {

	public enum MenuType {
		entre,
		drink,
		side,
	}

	MenuType _menuType; // put this on the actual item with the base.menuType = entre, hunter

	private int _cookTimeinSeconds;

	private float _price = 0;

	private bool _Completed = false;

	private DateTime _startcooking;

	public DateTime Get_StartCooking() {
		return _startcooking;
	}
	public void Set_StartCooking(DateTime d) {
		_startcooking = d;
	}

	public void Set_Completed(bool b) {
		_Completed = b;
	}
	public bool Get_Completed() {
		return _Completed;
	}
	

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

	public void Set_cookTime(int time) {
		_cookTimeinSeconds = time;
	}

	public int Get_cookTime() {
		return _cookTimeinSeconds;
	}
	
	private DateTime _startTime; // this is set when it is put into a "fryer", hunter


	public void StartCooking() {

		_startTime = DateTime.Now;

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

	// basically gets the name...
	public String Display() {

		return _name;

	}
	
}