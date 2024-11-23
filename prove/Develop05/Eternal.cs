namespace Develop05;

public class Eternal: Goal
{
    


    public Eternal(String n, String d, int p, int a, int c)
    {
        GSet_name(n);
        GSet_description(d);
        GSet_points(p);

        GSet_points(p);
        GSet_amount(a);
        GSet_completed(c);
        
    }

    public override int WhenCompletedPoints() {
        return GSet_points(-1) * GSet_completed(-1);
    }

    public override bool ConsideredComplete() {
        if (GSet_completed(-1) > 0) {
            return true;
        }
        return false;
    }

    public override void Display()
    {
        if(ConsideredComplete()) { Console.Write("[X]");}
        else               {Console.Write("[ ] "); }
        
        Console.Write(GSet_name(null)+ " ");
        Console.Write(GSet_description(null) + " ");
    }
    
    
    
    public override String SaveOutput() {
        return "Eternal" + "|" + GSet_name(null) + "|" + GSet_description(null) + "|" + GSet_points(-1) + "|" + GSet_amount(-1) + "|" + GSet_completed(-1);
    }
}