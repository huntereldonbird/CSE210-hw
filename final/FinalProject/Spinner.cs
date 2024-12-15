using System;
using System.Threading;

namespace FinalProject;

public class Spinner
{

    public String[] AnimationFrames =
    [
    "⣦",
    "⣮",
    "⣴",
    "⣪",
    "⣤",
    "⣥",
    "⣴",
    "⣦",
    "⣤"
    ];

    public Spinner() {
        
        Animate(1);
        
    }
    
    
    // iterations would be in reference to the amount of seconds it takes?
    // General rule, 1 itteration = 9 seconds because we have 9 frames of animation.
    public void Animate(int previous) {
        
        int index = previous;
        
        if (index >= AnimationFrames.Count() - 1)
        {
            index = 0;
        }
        
        Console.Write(AnimationFrames[index]);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        
        index++;

        Animate(index);
    }
}