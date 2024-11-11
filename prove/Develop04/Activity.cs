namespace Develop04;

class Activity
{
    private String _opener;
    private String _start = "Welcome to the Wellness application.";
    private String _ender = "Hopefully you are feelig better now!";

    private List<String> _prompts;

    // Leaving this note here for who ever grades this, I know this isnt exactally what was wanted, but I perfer doing it this way, let me know if I need to change this, hunter
    
    public List<String> GSetPromts(List<String> prompts) {
        if (prompts != null) { _prompts = prompts; }
        return _prompts;
    }
    
    public String GSetOpener(String s) {
        if (s != null) { _opener = s; }
        return _opener;
    }
    public String GSetStart(String s) {
        if (s != null) { _start = s; }
        return _start;
    }
    public String GSetEnder(String s) {
        if (s != null) { _ender = s; }
        return _ender;
    }

    public Activity()
    {
        
    }

    public void Begin()
    {
        Console.Clear();
        Console.WriteLine(GSetStart(null));
        Console.WriteLine();
        Console.WriteLine(GSetOpener(null));
        Console.WriteLine();
        Console.Write("For how many seconds would you like for this activity? ");
    }

    public void End()
    {
        Console.WriteLine("Well Done!");
        Spinner spinner = new Spinner();
        spinner.Animate(5);
        Console.WriteLine();
        Console.WriteLine(_ender);
        spinner.Animate(5);
    }

    
}