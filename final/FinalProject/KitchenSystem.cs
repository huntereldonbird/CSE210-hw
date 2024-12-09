using System.Data;

namespace FinalProject;

public class KitchenSystem {
    // consider adding ASCII art as a loading animation when an item is being prepared
    
    private int _numfryers;
    public KitchenSystem() {

        
        
        
        UpdateLoop();
    }

    public void UpdateLoop() {
        
        
        
        
        
        
        Thread.Sleep(1000);
        UpdateLoop();

    }

    public void CheckOnTicket(Ticket ticket) {

        MenuItem[] menuItems = ticket.Get_menu_items();
        
        



    }
}