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
        
        ACTIVATE();
    }

    
    
}