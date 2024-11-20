namespace Develop05;

public class Goal
{
    private String _name;
    private String _description;
    private int _points;
    bool _completed;

    public String GSet_name(String n) {
        if (n != null) { _name = n; }
        return _name;
    }
    public String GSet_description(String d) {
        if (d != null) { _description = d; }
        return _description;
    }
    public int GSet_points(int p) {
        if (p != null) { _points = p; }
        return _points;
    }
    public bool GSet_completed(bool c) {
        if (c != null) { _completed = c; }
        return _completed;
    }

    public Goal()
    {
        
    }

    public virtual String Display()
    {
        return "hi";
    }
    
}