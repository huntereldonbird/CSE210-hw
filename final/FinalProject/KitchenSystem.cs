using System.Data;

namespace FinalProject;

public class KitchenSystem {
    // consider adding ASCII art as a loading animation when an item is being prepared
    
    private int _numfryers;
    public KitchenSystem() {

        
        
        
        UpdateLoop();
    }

    public void UpdateLoop() {
        
        
        FryerSystem(4);
        
        
        Thread.Sleep(1000);
        UpdateLoop();

    }



    public void FryerSystem(int a) {
        
        
        
        
        
        
        
        FryerSystem(a -1);
        
    }
}