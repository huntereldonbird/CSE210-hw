namespace Develop05;

public class Eternal: Goal
{



    public Eternal(String n, String d, int p)
    {
        GSet_name(n);
        GSet_description(d);
        GSet_points(p);
        GSet_completed(false);
    }
}