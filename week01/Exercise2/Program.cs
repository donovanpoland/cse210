using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //overview
        //      Write a program that determines the letter grade for a course according to the following scale:
        //      A >= 90 B >= 80 C >= 70 D >= 60 F < 60
        //Assume that you must have at least a 70 to pass the class


        // ask user for their grade percentage
        Console.Write("What is your grad percentage? ");
        // store as string
        string grade = Console.ReadLine();
        //convert to float
        float percentage = float.Parse(grade);

        //create grade later message for reuse
        string gradeLetterMessage = "Your grade is:";

        //instantiate letter grade
        string letterGrade;

        //instantiate pass or fail
        bool passedOrNot;
        string outcome;

        //declare passed class message
        string passMessage = "Congratulations, you have passed the class.";
        string failMessage = "You have not passed the class, please try again.";

        // //step 2
        // if (percentage >= 90)
        // {
        //     Console.WriteLine($"{gradeLetterMessage}A");
        //     Console.WriteLine(passMessage);
        // }
        // else if (percentage < 90 && percentage >= 80)
        // {
        //     Console.WriteLine($"{gradeLetterMessage}B");
        //     Console.WriteLine(passMessage);
        // }
        // else if (percentage < 80 && percentage >= 70)
        // {
        //     Console.WriteLine($"{gradeLetterMessage}C");
        //     Console.WriteLine(passMessage);
        // }
        // else if (percentage < 70 && percentage >= 60)
        // {
        //     Console.WriteLine($"{gradeLetterMessage}D");
        //     Console.WriteLine(failMessage);
        // }
        // else
        // {
        //     Console.WriteLine($"{gradeLetterMessage}F");
        //     Console.WriteLine(failMessage);
        // }

    //part 3 check find letter grade and determine if passed class
        if (percentage >= 90)
        {
            letterGrade = "A";
            passedOrNot = true;
        }
        else if (percentage < 90 && percentage >= 80)
        {
            letterGrade = "B";
            passedOrNot = true;
        }
        else if (percentage < 80 && percentage >= 70)
        {
            letterGrade = "C";
            passedOrNot = true;
        }
        else if (percentage < 70 && percentage >= 60)
        {
            letterGrade = "D";
            passedOrNot = false;
        }
        else
        {
            letterGrade = "F";
            passedOrNot = false;
        }

        //check if passed class
        if (passedOrNot)
        {
            outcome = passMessage;
        }
        else
        {
            outcome = failMessage;
        }

        //display grade, and outcome of the class
        Console.WriteLine($"{gradeLetterMessage} {letterGrade}. {outcome}");
    }
}