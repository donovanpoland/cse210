using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {

        //Rules
        Console.WriteLine("Rules:");
        Console.WriteLine("in C# end all statements must end with ' ; ' or you will get an error");
        Console.WriteLine("Indentation does not mater but is convention to keep code clean, all code blocks will be contained in () or {} or []");

        //Write to the console
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        Console.WriteLine("Use 'Console.WriteLine(doublequote text doublequote);' to send text into the console with c#");
        Console.WriteLine("WriteLine will always produce a new line.");
        Console.Write("There will not be a newline after this. ");
        Console.Write("This sentence is a new command using Console.write() and will not create a new line but continue after the last.");

        //copy and paste purposes - im practically writing a book
        Console.WriteLine("");

        //Variables
        Console.WriteLine("Variables must be declared with a type.");
        Console.WriteLine("Variables types include: int, string, float, double, decimal, bool");
        Console.WriteLine("int - Integers (whole numbers, positive and negative)");
        Console.WriteLine("string - Strings (a sequence of characters, including letters, numbers, or symbols)");
        Console.WriteLine("float - Floating point numbers (numbers that use decimals)");
        Console.WriteLine("double - Double precision floating point numbers " + //Continue text on next line using "text" + "text" to 'add' the 2 strings together
         " (just like a float, except it takes up twice as much memory, so it can hold larger numbers or numbers with more decimal places) ");
        Console.WriteLine("bool - Boolean variables (true or false)");


        //declaration
        Console.WriteLine("Declaration: DataType variableName = variableDeclaration Ex: string name = Donovan;");

        //2 lines of declaration and 
        int number;
        number = 2;

        //single line declaration
        int secondNumber = 1;

        //variable types
        string stringOfText = "string of text";
        Console.WriteLine("Type: string, can only store text within double quotes");

        int integer = 1;
        Console.WriteLine("Type: int, can only store whole numbers");

        float floatingPoint = 1.1234567f;
        Console.WriteLine("Type: float, precise up to 7 digits, Size: 32 bits");
        Console.WriteLine("Use: Fast, less precise - graphics, scientific");

        double DPFloating = 1.1517;
        Console.WriteLine("Type: double, precise up to 15-17 digits, Size: 64 bits");
        Console.WriteLine("USe: Default for real numbers - general purpose");

        decimal decimals = 1.2829m;
        Console.WriteLine("Type: decimal, precise up to 28-29 digits, Size: 128 bits");
        Console.WriteLine("Use: High precision - finance, currency, accuracy");

        bool booleanTrue = true;
        bool booleanFalse = false;
        Console.WriteLine("Type: bool, must be declared as true or false, must be Case sensitive");
        Console.WriteLine("C# lowercase required: true/false");
        Console.WriteLine("java lowercase required: true/false");
        Console.WriteLine("python uppercase required: True/False");

        Console.WriteLine("Using Variables");
        Console.WriteLine($"string:{stringOfText} int:{integer} float:{floatingPoint} double:{DPFloating} decimal:{decimals} bool(true):{booleanTrue} bool(false):{booleanFalse}");


        //Collect data from user
        //prompt or label
        Console.WriteLine("Ask your question here?");
        //store the response in a variable - Variables explanation below
        //no text can go inside ReadLine function
        string answer = Console.ReadLine();
        //You can place your variable inside the WriteLine() function directly
        Console.WriteLine(answer);
        //or you can add text in 2 different ways
        Console.WriteLine("Your answer is: " + answer);// add the plus sign to 'concatenate' or combine the string of your console text and the variable together
        //or you can use a formatter inside your console text using $ before your double quotes and {variable} inside your double quotes
        Console.WriteLine($"Your answer is: {answer}");

        //Variables are great when used for math
        int math = number + secondNumber;
        Console.WriteLine($"{number} + {secondNumber} = {math}");

    }
}