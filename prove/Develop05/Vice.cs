namespace Develop05;

public class Vice: Goal
{
    
    
    public Vice(String n, String d, int p)
    {
        GSet_name(n);
        GSet_description(d);
        GSet_points(p);
        GSet_completed(false);
    }
}