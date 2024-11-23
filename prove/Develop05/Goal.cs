namespace Develop05;

public class Goal
{
    private String _name;
    private String _description;
    private int _points;
    private int _completed;
    private int _amount;

    public String GSet_name(String n) {
        if (n != null) { _name = n; }
        return _name;
    }
    public String GSet_description(String d) {
        if (d != null) { _description = d; }
        return _description;
    }
    public virtual int GSet_points(int p) {
        if (p != null) { _points = p; }
        return _points;
    }
    public virtual int GSet_completed(int c) {
        if (c >= 0) { _completed = c; }
        return _completed;
    }

    public virtual int GSet_amount(int a)
    {
        if (a >= 0) { _amount = a; }
        return _amount;
    }

    public Goal()
    {
        
    }

    public virtual void Display()
    {
        if(_completed > 0) { Console.Write("[X] ");}
        else               {Console.Write("[ ] "); }
        
        Console.Write(GSet_name(null)+ " ");
        Console.Write(GSet_description(null) + " ");
    }

    public virtual String SaveOutput() {
        return "Goal" + "|" + GSet_name(null) + "|" + GSet_description(null) + "|" + GSet_points(-1) + "|" + GSet_amount(-1) + "|" + GSet_completed(-1);
    }
    
}