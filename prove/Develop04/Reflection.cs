namespace Develop04;
using System;

class Reflection: Activity
{
    private List<String> _reflectionPrompts =
    [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];
    
    public Reflection()
    {
        GSetOpener("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        GSetStart("Welcome to the Relfection Activity");
        List<String> tprompts =
        [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        
        GSetPromts(tprompts);

    }

    public void DoThis()
    {
        Begin();

        int userInput = Int32.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Get Ready...");
        
        Spinner spinner1 = new Spinner();
        spinner1.Animate(5);
        Console.WriteLine();

        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine();
        
        Random rand = new Random();
        int rng = rand.Next(GSetPromts(null).Count);
        Console.WriteLine("  ---  " + GSetPromts(null)[rng] + "  ---  ");
        
        Console.WriteLine("When you have something in mind, press enter to continue.");
        
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.Enter)
        {
            
            Console.WriteLine("Now ponder on each of the following questions as they related to this expereince.");
            Console.Write("You may begin in: ");
            spinner1.CountDown(5);
            
            Console.Clear();
            
            DateTime startTime = DateTime.Now;
            int index = 0;
            while (DateTime.Now <= startTime.AddSeconds(userInput))
            {
                Console.WriteLine(_reflectionPrompts[index]);
            
                Spinner spinner = new Spinner();
                spinner.Animate(4);
            
            
                index++;
            }

            Console.Clear();
            GSetEnder("You have completed another " + userInput.ToString() + " seconds of the Reflecting Activity.");
            End();
        }

    }
}