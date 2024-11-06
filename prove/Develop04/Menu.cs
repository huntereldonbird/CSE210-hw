namespace Develop04;

public class Menu
{
    

    private int AmountInSeconds;

    public void Starter()
    {
        Console.WriteLine("Welcome the wellness helper!");
        
        
        
        Console.WriteLine("Breathing = 1,");
        Console.WriteLine("Refelcting = 2,");
        Console.WriteLine("Listening = 3,");
        
        String UserInput = Console.ReadLine();

        switch (Int32.Parse(UserInput))
        {
            case 1:
                Breathing breathing = new Breathing();
                breathing.DoThis();
                break;
            case 2:
                Reflection reflection = new Reflection();
                break;
            case 3:
                Listening listening = new Listening();
                break;
        }
    }
}