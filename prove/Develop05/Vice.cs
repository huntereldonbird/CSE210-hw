namespace Develop05;

public class Vice: Goal
{

    
    
    public Vice(String n, String d, int p, int a, int c)
    {
        GSet_name(n);
        GSet_description(d);
        GSet_points(p);


        if( p != -1){ GSet_points(p);}
        if( c != -1){ GSet_completed(c);}
    }
    
    public override void Display()
    {
        if(AreYouDone()) { Console.Write("[X] ");}
        else               {Console.Write("[ ] "); }
        
        Console.Write(GSet_name(null)+ " ");
        Console.Write(GSet_description(null) + " ");
    }
    
    public override String SaveOutput() {
        return "Vice" + "|" + GSet_name(null) + "|" + GSet_description(null) + "|" + GSet_points(-1) + "|" + GSet_amount(-1) + "|" + GSet_completed(-1);
    }
}