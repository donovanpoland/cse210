

class FractionArgs
{
    public void RunFractionArgs()
    {
        //set top and bottom
        int top = 2;
        int bottom = 4;


        //testing the fractions constructor with top and bottom as arguments
        Fraction fractionArgs1 = new Fraction(top, bottom);//default values
        //numbers can also be placed directly into the arguments
        Fraction fractionArgs2 = new Fraction(7, 10);

        int getTop = fractionArgs1.GetTop();
        int getBottom = fractionArgs1.GetBottom();

        int getTop2 = fractionArgs2.GetTop();
        int getBottom2 = fractionArgs2.GetBottom();

        Console.WriteLine($"calling the methods directly: Top: {fractionArgs1.GetTop()} Bottom: {fractionArgs1.GetBottom()}");
        Console.WriteLine($"set variable to get methods: Top: {getTop} Bottom: {getBottom}");

        //set new top and bottom
        Console.WriteLine("\nset new top and bottom");
        //must change variables not just set new number
        fractionArgs1.SetTop(3);
        fractionArgs1.SetBottom(5);
        

        Console.WriteLine("call new top and bottom");
        Console.WriteLine($"calling the methods directly: Top: {fractionArgs1.GetTop()} Bottom: {fractionArgs1.GetBottom()}");
        Console.WriteLine($"NOT getting the variable after setting: Top: {getTop} Bottom: {getBottom}");

        //you must get the variables again after changing them or they will be the same
        getTop = fractionArgs1.GetTop();
        getBottom = fractionArgs1.GetBottom();
        Console.WriteLine($"\nGetting variables after set: Top: {getTop} Bottom: {getBottom}");


        //using to string method
        string fraction = fractionArgs1.FractionString();
        Console.WriteLine($"\nstring version: {fraction}");

        //using to decimal method
        double dec = fractionArgs1.GetDecimalValue();
        Console.WriteLine($"Convert to decimal: {dec}");

        //using second object with new default values of top:7 bottom:10
        Console.WriteLine($"\nSecond fraction object: Top: {getTop2} Bottom: {getBottom2}");
    }
}