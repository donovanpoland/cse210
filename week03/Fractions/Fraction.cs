
class Fraction
{
    //variables
    private int _top;//numerator
    private int _bottom;//denominator
    private bool _isWholeNumberConstructor = false;

    //constructors
    //default constructor
    public Fraction()
    {

    }

    //use this constructor when you want whole numbers only
    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
        _isWholeNumberConstructor = true;
    }

    //use this constructor when you want to set the top and bottom with default values
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //methods
    //get the top/numerator of the fraction
    public int GetTop()
    {
        return _top;
    }

    //set the top/numerator of the fraction
    public void SetTop(int top)
    {
        _top = top;
    }

    //get bottom/denominator of the fraction
    public int GetBottom()
    {
        return _bottom;
    }

    //set the bottom/denominator of the fraction
    public void SetBottom(int bottom)
    {
        //if true then you are not allowed to set the bottom
        if (_isWholeNumberConstructor)
        {
            Console.WriteLine("\nCannot change bottom of a whole number fraction.");
            return;
        }

        //cannot be 0 
        if (bottom == 0)
        {
            Console.WriteLine("\nDenominator cannot be zero.");
            return;
        }

        //set bottom
        _bottom = bottom;
    }// close set bottom

    //change the fraction to a string
    public string FractionString()
    {
        return $"{_top}/{_bottom}";
    }// close fraction to string

    //convert the fraction to a decimal value
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }// close get decimal
}