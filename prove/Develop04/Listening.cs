namespace Develop04;
using System;

class Listening: Activity
{
    // By the way putting this here, I just realised it was called LISTING and not listening. I however am too lazy to fix this. please forgive me, hunter
    public Listening()
    {
        
        GSetOpener("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        GSetStart("Welcome to the Listing Activity");
        List<String> listeningPrompts =
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
        GSetPromts(listeningPrompts);
    }
    
    
    public void DoThis()
    {
        Begin();
        
        int userinput = Int32.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Get Ready...");
        
        Spinner spinner1 = new Spinner();
        spinner1.Animate(5);
        Console.WriteLine();
        
        Random rand = new Random();
        int rng = rand.Next(GSetPromts(null).Count);
        Console.WriteLine("  ---  " + GSetPromts(null)[rng] + "  ---  ");
        
        Console.WriteLine();
        Console.Write("You may begin in: ");
        spinner1.CountDown(5);
        Console.WriteLine();

        DateTime now = DateTime.Now;

        int i = 0;
        
        while (DateTime.Now < now.AddSeconds(userinput))
        {
            Console.Write(">");
            String input = Console.ReadLine();
            i++;
        }

        Console.WriteLine("You listed " + i.ToString() + " items!");
        Console.WriteLine();
        
        GSetEnder("You have compelted another " + userinput.ToString() + " seconds of the Listing Activity");
        End();
    }
    
    
}