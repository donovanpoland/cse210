
//tests the default constructor of the Fraction class
class FractionsDefault
{

    public void RunDefault()
    {
        Fraction fractionDefault = new Fraction();

        // set fraction to 3/4
        //set top of default constructor
        fractionDefault.SetTop(3);
        //set bottom of default constructor
        fractionDefault.SetBottom(4);
        //get top
        int fractionTop = fractionDefault.GetTop();
        //get bottom
        int fractionBottom = fractionDefault.GetBottom();
        Console.WriteLine("Default constructor using SetTop and SetBottom methods and then GetTop and GetBottom methods.");
        Console.WriteLine($"Top: {fractionTop} Bottom: {fractionBottom}");
        Console.WriteLine("\nchange the same variables.");
        // set fraction to 3/4
        //set top of default constructor
        fractionDefault.SetTop(7);
        //set bottom of default constructor
        fractionDefault.SetBottom(10);
        //get top
        fractionTop = fractionDefault.GetTop();
        //get bottom
        fractionBottom = fractionDefault.GetBottom();
        Console.WriteLine($"Top: {fractionTop} Bottom: {fractionBottom}");


        //using to string method
        string fraction = fractionDefault.FractionString();
        Console.WriteLine($"\nstring version: {fraction}");

        //using to decimal method
        double dec = fractionDefault.GetDecimalValue();
        Console.WriteLine($"Convert to decimal: {dec}");

    }
}