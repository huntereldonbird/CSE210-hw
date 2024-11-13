namespace Learning05;

public class Shape
{
    private String _color;

    public String GetColor() { return _color; }
    public void SetColor(String c) { _color = c; }

    public virtual double GetArea()
    {
        return 0;
    }
}