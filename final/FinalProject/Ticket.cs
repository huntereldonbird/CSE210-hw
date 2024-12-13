using System.ComponentModel.Design;
using System.Runtime.InteropServices.JavaScript;
using System.Xml.XPath;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinalProject;
using System;

public class Ticket {

	
	// when this is called, it automatiically adds the datetime btw, hunter
	public Ticket(MenuItem[] menuItems, int id) {
		
		_menuItems = menuItems;
		
		_orderid = id;

		_created = DateTime.Now;


	}

	[JsonConstructor]
	public Ticket() {
		
	}
	
	// FOR GIBBONS/AMMON, I sadly needed to include the default getters and setters for the JSon serializer
	// otherwise I used the getters and setters that I had made, hunter
	
	private MenuItem[] _menuItems { get; set; }
	
	private int _orderid { get; set; }
	
	private String OrderName { get; set; } // for later if we want to..., hutner

	private DateTime _created { get; set; }

	private bool _complted { get; set; }



	public String Display() {

		String result = "" + _orderid + " : [ " ;

		foreach (MenuItem i in _menuItems) {

			result += "" + i.Display() + ", ";

		}
		
		result += "]";

		return result;
	}

	public void add_Menu_item(MenuItem menuItem) {
		
		_menuItems.Append(menuItem);
		
	}

	public MenuItem[] Get_menu_items() {
		return _menuItems;
	}
	
	public int Get_orderid() {
		return _orderid;
	}

	public void Set_orderid(int orderid) {
		_orderid = orderid;
	}
	public void Set_Complete(bool b) {
		_complted = b;
	}

	public bool Get_Complted() {
		return _complted;
	}
	
}