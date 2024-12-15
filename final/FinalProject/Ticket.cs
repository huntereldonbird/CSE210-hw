using System.ComponentModel.Design;
using System.Runtime.InteropServices.JavaScript;
using System.Xml.XPath;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinalProject;
using System;

public class Ticket {

	
	// when this is called, it automatiically adds the datetime btw, hunter
	public Ticket(MenuItem[] menuItems) {
		
		_menuItems = menuItems;


		_created = DateTime.Now;
		
		Random rand = new Random();
		_orderid = rand.Next(0, 10000000);


	}

	[JsonConstructor]
	public Ticket() {
		
	}
	
	// FOR GIBBONS/AMMON, I sadly needed to include the default getters and setters for the JSon serializer
	// otherwise I used the getters and setters that I had made, hunter
	public MenuItem[] _menuItems { get; set; }
	
	public int _orderid { get; set; }
	
	public String OrderName { get; set; } // for later if we want to..., hutner

	public DateTime _created { get; set; }


	public String Display() {

		String result = "" + _orderid + " : [ " ;

		foreach (MenuItem i in Get_menu_items()) {

			if (i.Get_Completed()) {
				result += "\u2713 : " + i.Display() + ", ";
			}
			else {
				result += "X : " + i.Display() + ", ";
			}
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

	
	// if any ticket is not completed, then the ticket isnt done, otherwise it is completed.
	public bool Get_Complted() {

		bool result = true;

		foreach (var menuitem in Get_menu_items()) {

			if (!menuitem.Get_Completed()) {
				result = false;
			}
		}

		return result;
	}

	public double Get_Total_Price() {

		int result = 0;

		foreach (MenuItem menuitem in Get_menu_items()) {

			result += menuitem.Get_price();

		}

		double tax = result * 0.07;

		return result + tax;
	}

	public double Get_Total_Cost() {
		double result = 0;

		foreach (MenuItem menuitem in Get_menu_items()) {

			result += menuitem.Get_cost();

		}
		
		return result;
	}

	public DateTime Get_created() {
		return _created;
	}

}