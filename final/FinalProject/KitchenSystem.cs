using System.Data;

namespace FinalProject;

public class KitchenSystem {
    // consider adding ASCII art as a loading animation when an item is being prepared

    private FoodTruck _foodTruck;

    private int _fryers;
    
    public KitchenSystem(FoodTruck foodTruck) {

        _foodTruck = foodTruck;
     
    }

    
    
    // this is the area for the code when someone actually enters the code from the foodtruck menu, hunter
    // Only incude visuals and controls from here please...

    public void BeginSession() {
        
        Console.Clear();
        
        Console.WriteLine("Kitchen System : ");

        foreach (var ticket in _foodTruck.LoadTickets()) {
            Console.WriteLine("-----------------------");
            Console.WriteLine(ticket.Display());
            //maybe here???
            Spinner spinner = new Spinner();
            spinner.Animate(7);           
            
        }
        
            Console.WriteLine("-----------------------");
        


        Console.WriteLine("c : refresh, q : quit");

        string userin = Console.ReadLine();

        switch (userin) {
			
            case("c"):
                BeginSession();
                break;
            case("q"):
                Console.Clear();
                break;
        }
    }   

}