using System.Net.NetworkInformation;

public class Shape
{

    //variables
    private string _color;
    private string _shape;

    public Shape()
    {
        _color = "none";
        _shape = "none";
    }


    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

        public string GetShape()
    {
        return _shape;
    }

    public void SetShape(string shape)
    {
        _shape = shape;
    }


    //abstract class has no body
    public virtual double GetArea()
    {
        return -1;
    }


}