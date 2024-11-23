namespace Develop05;

public class Eternal: Goal
{



    public Eternal(String n, String d, int p, int a, int c)
    {
        GSet_name(n);
        GSet_description(d);
        GSet_points(p);

        if (c != null) {
            GSet_completed(c); 
        }
        
    }
    
    public virtual String SaveOutput() {
        return "Eternal" + "|" + GSet_name(null) + "|" + GSet_description(null) + "|" + GSet_points(-1) + "|" + GSet_amount(-1) + "|" + GSet_completed(-1);
    }
}