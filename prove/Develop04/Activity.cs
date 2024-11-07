namespace Develop04;

class Activity
{
    private String _Opener;
    private String _Start = "Welcome to the Wellness application.";
    private String _Ender = "Hopefully you are feelig better now!";

    private List<String> _Prompts;

    public List<String> gsetPromts(List<String> prompts)
    {
        if (prompts != null)
        {
            _Prompts = prompts;
        }

        return _Prompts;
    }
    
    public String gsetOpener(String s) {
        if (s != null) { _Opener = s; }
        return _Opener;
    }
    public String gsetStart(String s) {
        if (s != null) { _Start = s; }
        return _Start;
    }
    public String gsetEnder(String s) {
        if (s != null) { _Ender = s; }
        return _Ender;
    }

    public Activity()
    {
        
    }

    public void Begin()
    {
        Console.WriteLine(_Start);
    }

    public void End()
    {
        Console.WriteLine(_Ender);
    }

    
}