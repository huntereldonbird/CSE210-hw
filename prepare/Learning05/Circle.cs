namespace Learning05;

public class Circle: Shape
{
    double _radius;

    public override double GetArea()
    {
        return _radius * _radius * Double.Pi;
    }
    
    public Circle(double rad, String color)
    {
        _radius = rad;
        base.SetColor(color);
    }
}