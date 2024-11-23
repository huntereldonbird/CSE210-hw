namespace Develop05;

public class Simple : Goal
{
    
    
    public Simple(String n, String d, int p, int a, int c)
    {
        GSet_name(n);
        GSet_description(d);
        base.GSet_points(p);

        if (c != null) {
            base.GSet_completed(c);
        }
    }
    
    public virtual String SaveOutput() {
        return "Simple" + "|" + GSet_name(null) + "|" + GSet_description(null) + "|" + GSet_points(-1) + "|" + GSet_amount(-1) + "|" + GSet_completed(-1);
    }
}