using System.Globalization;

namespace Develop04;

using System;

class Breathing : Activity
{
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

        int userin = Int32.Parse(Console.ReadLine());
        while (userin > 0)
        {

            if (userin < 5)
            {
                continue;
            }

            Console.Write("Breath in...");

            Spinner spinner = new Spinner();
            spinner.CountDown(4);


            Console.WriteLine();
            Console.Write("Breath out...");
            spinner.CountDown(6);
            
            Console.WriteLine();


            userin -= 10;
        }
        Console.WriteLine(gsetEnder(null));
    }
}