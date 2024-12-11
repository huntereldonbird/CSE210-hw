
namespace FinalProject;
using System;

public class Ticket {

	
	// when this is called, it automatiically adds the datetime btw, hunter
	public Ticket(MenuItem[] menuItems, int id) {
		
		_menuItems = menuItems;

		_orderid = id;

		_created = DateTime.Now;


	}

	public String Display() {

		String result = "" + _orderid + " : [ " ;

		foreach (MenuItem i in _menuItems) {

			result += "" + i.Display() + ", ";

		}
		
		result += "]";

		return result;
	}
	
	
	private MenuItem[] _menuItems;

	public void add_Menu_item(MenuItem menuItem) {
		_menuItems.Append(menuItem);
	}

	public MenuItem[] Get_menu_items() {
		return _menuItems;
	}

	private int _orderid;

	public int Get_orderid() {
		return _orderid;
	}

	public void Set_orderid(int orderid) {
		_orderid = orderid;
	}

	private String OrderName = ""; // for later if we want to..., hutner

	private DateTime _created;

	private bool _complted;

	public void Set_Complete(bool b) {
		_complted = b;
	}

	public bool Get_Complted() {
		return _complted;
	}
}