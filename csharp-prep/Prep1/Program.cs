using System;

class Program
{
    
    static void Main(string[] args){
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your family name");
        string familyName = Console.ReadLine();

        Console.WriteLine("Your name is " + familyName + ", " + firstName + " " + familyName);
    }


}