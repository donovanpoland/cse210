public class Square : Shape
{
    private double _side;

    public Square(double side)
    {
        _side = side;
        SetShape("Square");
    }


    public override double GetArea()
    {
        return _side * _side;
    } 

    
}