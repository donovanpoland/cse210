using System;

class Program
{
    static void Main(string[] args)
    {
        //clear console for clarity
        Console.Clear();

        //test default constructor for the fractions class
        /*Uncomment to test*/
        // FractionsDefault fractionsDefault = new FractionsDefault();
        // fractionsDefault.RunDefault();


        //test Whole number constructor for the fractions class
        /*Uncomment to test*/
        // FractionsWhole fractionsWhole = new FractionsWhole();
        // fractionsWhole.RunWhole();

        //test constructor with top and bottom arguments for the fractions class
        /*Uncomment to test*/
        FractionArgs fractionArgs = new FractionArgs();
        fractionArgs.RunFractionArgs();

    }
}