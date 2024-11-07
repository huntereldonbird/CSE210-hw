using System;
using System.Threading;

namespace Develop04;

public class Spinner
{

    public void ACTIVATE()
    {
        
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write(".");
            
        
        Thread.Sleep(500);
        
        Console.Write("\b \b");
        
        ACTIVATE();
    }

    public void CountDown(int seconds)
    {
        for (int i = 0; i <= seconds; )
        {
            Console.Write(i);
            
            Thread.Sleep(1000);

            Console.Write("\b \b");

            i++;
                
        }
    }

    
    
}