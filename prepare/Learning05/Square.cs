namespace Learning05;

public class Square: Shape
{
    private double _side;

    public override double GetArea()
    {
        return _side * _side;
    }

    public Square(double sides, String color)
    {
        _side = sides;
        base.SetColor(color);
    }
}