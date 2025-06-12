using System;


class Program
{
    static void Main(string[] args)
    {


        

        Rectangle rectangle = new Rectangle(4, 6);
        rectangle.SetColor("Red");

        Square square = new Square(5);
        square.SetColor("Blue");

        Circle circle = new Circle(2);
        circle.SetColor("Green");

        List<Shape> shapes = [rectangle, square, circle];


        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string shapeName = shape.GetShape();
            Console.WriteLine($"The {shape.GetColor()} {shapeName} has an area of {area}");
        }
        
        
        
        
    }
}