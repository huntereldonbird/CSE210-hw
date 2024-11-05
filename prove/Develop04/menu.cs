namespace Develop04;

public class menu
{
    private String universalStart = "Welcome to Wellness Program";
    private String _QuestionPrompt = "What activity would you like to do today?:";

    private int AmountInSeconds;

    public void Starter()
    {
        Console.WriteLine(universalStart);
        Console.WriteLine(_QuestionPrompt);
        Console.WriteLine("Breathing = 1,");
        Console.WriteLine("Refelcting = 2,");
        Console.WriteLine("Listening = 3,");
        
        String UserInput = Console.ReadLine();

        switch (Int32.Parse(UserInput))
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
        
        
    }



}