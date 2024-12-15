using System;
using FinalProject;

class Program
{
    static void Main(string[] args)
    {
        
        Task task1 = new Task(() => {
            
            FoodTruckProcess process = new FoodTruckProcess();
            
        });
        
        
        
        Task task2 = new Task(() => {
            
            FoodTruck _foodtruck = new FoodTruck();
            
        });
        
        task1.Start();

        //task2.Start();
        
        FoodTruck foodTruck = new FoodTruck(); // WIll have to see if I even need to have a task..., hunter
        
    }
}