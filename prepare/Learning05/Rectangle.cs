namespace Learning05;

public class Rectangle: Shape
{
    private double _height;
    double _width;

    public override double GetArea()
    {
        return _width * _height;
    }
    
    public Rectangle(double sidesWidth, double sidesHeight, String color)
    {
        _height = sidesHeight;
        _width = sidesWidth;
        base.SetColor(color);
    }
}