using System;
using System.Threading;

namespace Develop04;

public class Spinner
{

    public String[] AnimationFrames =
    [
    "/",
    "-",
    "\\",
    "|"
    ];
    
    
    // iterations would be in reference to the amount of seconds it takes?
    // General rule, 1 itteration = 4 seconds because we ahve 4 frames of animation.
    public void Animate(int seconds)
    {
        DateTime endtime = DateTime.Now.AddSeconds(seconds);

        int index = 0;
        while (DateTime.Now < endtime)
        {
            if (index >= AnimationFrames.Count())
            {
                index = 0;
            }
            
            Console.Write(AnimationFrames[index]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            index++;
        }
    }
    
    public void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; )
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
    }

    
    
}