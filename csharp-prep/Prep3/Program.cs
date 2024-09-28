using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        int Magic = new Random().Next(0, 11);
        int guess = -1;
        int Counter = 0;

        do {

            Counter++;
            Console.Write("What is your guess :");
            guess = int.Parse(Console.ReadLine());

            if (Magic > guess){
                Console.WriteLine("Higher");
            }
            else if (guess > Magic){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine($"You guessed right in {Counter} Moves");
            }


        }
        while (guess != Magic);
    }
}