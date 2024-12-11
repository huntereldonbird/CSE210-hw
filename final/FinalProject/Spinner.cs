using System;
using System.Threading;

namespace FinalProject;

public class Spinner
{

    public String[] AnimationFrames =
    [
    "░",
    "▒",
    "▓"
    ];
    
    
    // iterations would be in reference to the amount of seconds it takes?
    // General rule, 1 itteration = 3 seconds because we have 3 frames of animation.
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
}