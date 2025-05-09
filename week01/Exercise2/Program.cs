using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //overview
        //      Write a program that determines the letter grade for a course according to the following scale:
        //      A >= 90 B >= 80 C >= 70 D >= 60 F < 60
        //Assume that you must have at least a 70 to pass the class
        //Strech challange
        //      Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. 
        //      For each grade, you'll know it is a "+" if the last digit is >= 7. 
        //      You'll know it is a minus if the last digit is < 3 and otherwise it has no sign.

        // ask user for their grade percentage
        Console.Write("What is your grad percentage? ");
        // store as string
        string grade = Console.ReadLine();
        //convert to float
        float percentage = float.Parse(grade);

        //create grade later message for reuse
        string gradeLetterMessage = "Your grade is:";

        //define grade signs
        string plus = "+";
        string minus = "-";
        string sign;

        //collect the last digit of percentage with casting and modulus
        //convert to int for easy modulus usage
        int lastdigit = ((int)percentage) % 10;

        //instantiate letter grade
        string letterGrade;

        //instantiate pass or fail
        bool passedOrNot;

        //declare outcome of class message
        string passMessage = "Congratulations, you have passed the class.";
        string failMessage = "You have not passed the class, please try again.";
        string finalOutcome;

        //step 2
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
            finalOutcome = passMessage;
        }
        else
        {
            finalOutcome = failMessage;
        }

        //determine sign or not
        if (lastdigit <= 3)
        {
            sign = minus;
        }
        else if (lastdigit >= 7)
        {
            sign = plus;
        }
        else
        {
            sign = "";
        }

        //check if percentage is greater than 97% to prevent A+ or if less than 60 to prevent f- or f+
        if (percentage >= 97 || percentage < 60)
        {
            sign = "";
        }

        //display grade, and outcome of the class
        Console.WriteLine($"{gradeLetterMessage} {letterGrade}{sign}. {finalOutcome}");
    }
}