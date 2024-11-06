namespace Develop04;

using System;

class Breathing : Activity
{

    private String _bi = "Breath in....";
    private String _bo = "Breath out....";

    public Breathing()
    {

        gsetOpener("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        
        
        
    }

    public void DoThis()
    {
        
        Console.Clear();
        
        Console.WriteLine(gsetOpener(null));

        Console.WriteLine(gsetStart(null));
        
        Console.WriteLine("For how many seconds would you like for this activity?: ");

        String userin = Console.ReadLine();

        for(int f = Int32.Parse(userin); f < 0; f-=5)
        {
            
        }


    }

}