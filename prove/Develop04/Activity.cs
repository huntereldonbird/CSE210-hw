namespace Develop04;

class Activity
{
    private String Opener;
    private String Start = "Welcome to the Wellness application.";

    public String gsetOpener(String s) {
        if (s != null) { Opener = s; }
        return Opener;
    }

    public Activity()
    {
        
    }

    
    public void DoThis()
    {
        Console.WriteLine(gsetOpener(null));
        
        
        
        
    }
    
}