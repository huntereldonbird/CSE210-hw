using System.Globalization;

namespace Develop04;

using System;

class Breathing : Activity
{
    public Breathing()
    {
        gsetOpener("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        gsetStart("Welcome to the Breathing Activity");
    }

    public void DoThis()
    {
        Begin();
        
        int userin = Int32.Parse(Console.ReadLine());
        
        DateTime now = DateTime.Now;

        while (DateTime.Now < now.AddSeconds(userin))
        {
            
            Console.Write("Breath in...");

            Spinner spinner = new Spinner();
            spinner.CountDown(4);
            
            Console.WriteLine();
            Console.Write("Breath out...");
            spinner.CountDown(6);
            
            Console.WriteLine();
            
        }
        Console.Clear();
        gsetEnder("You have completed another " + userin.ToString() + " seconds of the Breathing Activity.");
        End();
    }
}