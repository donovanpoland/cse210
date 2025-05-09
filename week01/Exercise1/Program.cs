using System;

class Program
{
    static void Main(string[] args)
    {
        //Overview
        //      An iconic line from the James Bond movies is that he would introduce himself as "Bond, James Bond." 
        //      For this assignment you will write a program that asks for your name and repeats it back in this way.
        //Assignment
        //      Prompt the user for their first name. Then, prompt them for their last name. 
        //      Display the text back all on one line saying, "Your name is last-name, first-name, last-name" as shown:

        //Prompt user for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        //capitalize first name?

        //prompt user for last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        //capitalize last name?

        //display full name with last name first in jame bond style
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}