namespace Learning05;

public class Menu
{

    public void Begin()
    {

        List<Shape> shapes = new List<Shape>();

        Square square = new Square(10, "red");
        Rectangle rectangle = new Rectangle(10, 5, "blue");
        Circle circle = new Circle(5, "green");

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)    
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
            
        }

    }
    
    
    
}