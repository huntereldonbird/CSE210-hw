using System.ComponentModel;

namespace FinalProject;

public class MenuItem {

	enum MenuType {
		entre,
		drink,
		side,
	}
	
	MenuType menuType; // put this on the actual item with the base.menuType = entre, hunter

	private int cookTimeinMinutes;
	
	private DateTime _startTime; // this is set when it is put into a "fryer", hunter


	public void StartCooking() {

		_startTime = DateTime.Now;

	}
	
}