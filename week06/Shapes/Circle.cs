public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
        SetShape("Circle");
    }


    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    } 
}