using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int square = SquareNumber(favoriteNumber);
        DisplayResult(userName, square);



    }//end main

    static void DisplayWelcome()
    {
        Console.WriteLine("\nWelcome to the program!");
    }//end DisplayWelcome method

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int favoriteNumber)
    {
        int square = favoriteNumber * favoriteNumber;
        return square;
    }

    private static void DisplayResult(string userName, int square)
    {

        Console.WriteLine($"{userName}, the square of your number is {square}");
    }





}//end program