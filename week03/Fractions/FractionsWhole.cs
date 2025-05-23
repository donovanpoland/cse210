

class FractionsWhole
{
    public void RunWhole()
    {

        //changing this number will change the top
        int wholeNumber = 5;

        Fraction fractionsWhole = new Fraction(wholeNumber);

        // Get top and bottom
        int top = fractionsWhole.GetTop();
        int bottom = fractionsWhole.GetBottom();

        // Print values using Get methods
        Console.WriteLine($"Top: {top}  Bottom: {bottom}");

        // Use your FractionString method (e.g., "1/1")
        string fractionString = fractionsWhole.FractionString();
        Console.WriteLine($"String version: {fractionString}");

        // Get decimal value
        double decimalValue = fractionsWhole.GetDecimalValue();
        Console.WriteLine($"Convert to decimal: {decimalValue}");

        /*protected against set bottom to force the fraction to ba a...
          whole number when using this constructor*/
        fractionsWhole.SetBottom(9);
        bottom = fractionsWhole.GetBottom();
        Console.WriteLine("\nAfter attempting to set a new bottom when using whole number constructor");
        Console.WriteLine($"Top: {top}  Bottom: {bottom}");


    }
}