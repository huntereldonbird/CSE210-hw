
namespace FinalProject;
using System;

public class Ticket {

	public Ticket(MenuItem[] menuItems, int id) {
		
		_menuItems = menuItems;

		_orderid = id;
		
		


	}

	public String Display() {


		return "Ticket Output here";
	}
	
	
	private MenuItem[] _menuItems;

	private int _orderid;

	private DateTime _created;

	private bool complted;



}