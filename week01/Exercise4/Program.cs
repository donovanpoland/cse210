using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
//so i don't have to type console every time I need to use it.
using static System.Console;
//max and min library
using System.Linq;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {

        //create new list to hold numbers
        List<int> numbers = new List<int>();
        //ask user for list of numbers - store input - add to list
        Write("\nEnter a list of numbers, type 0 when finished. ");
        int UserInput = int.Parse(ReadLine());
        numbers.Add(UserInput);

        //declare outputs
        int sum = 0;
        float average;
        int largest = int.MinValue;
        int smallestNumber = int.MaxValue;
        int smallestPositive = int.MaxValue;
        int endInput = 1;


        //Check if user input is 0 and remove from list if it is.
        if (UserInput == 0)
        {
            numbers.Remove(0);
            WriteLine("Cannot add 0 to the list.");
            //enter loop
            do
            {
                Write("Add another? ");
                UserInput = int.Parse(ReadLine());
                if (UserInput != 0)
                {
                    numbers.Add(UserInput);
                }
                else
                {
                    endInput = UserInput;
                }
            } while (endInput != 0);
            // end do while
        }
        else
        {
            //enter loop
            do
            {
                Write("Add another? ");
                UserInput = int.Parse(ReadLine());
                if (UserInput != 0)
                {
                    numbers.Add(UserInput);
                }
                else
                {
                    endInput = UserInput;
                }
            } while (endInput != 0);
            // end do while
        }//end check input if statement

        //Display list testing as is
        Write("\nList: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Write($"{numbers[i]}, ");
        }

        if (numbers.Count > 0)
        {
            //print Sum of numbers
            foreach (int number in numbers)
            {
                sum += number;
            }
            WriteLine($"\nThe sum is: {sum}");

            //find average
            average = (float)sum / numbers.Count;
            WriteLine($"The average is: {average}");

            //find largest number using a loop
            foreach (int number in numbers)
            {
                if (number >= largest)
                {
                    largest = number;
                }
            }
            //display largest number
            WriteLine($"Largest number is: {largest} found using a loop");
            WriteLine($"Largest number is: {numbers.Max()} using the Max() method");

            //find smallest number
            foreach (int number in numbers)
            {
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }

            //display smallest number
            WriteLine($"Smallest number is: {smallestNumber} found using a loop");
            WriteLine($"Smallest number is: {numbers.Min()} using the Min() method");
            WriteLine($"Smallest positive number is: {smallestPositive} found using a loop");

            //sort list
            numbers.Sort();
            Write("Sorted list: ");
            foreach (int number in numbers)
            {
                Write($"{number}, ");
            }

        }// end math if numbers are in the list
        else
        {
            WriteLine("No numbers in the list. Good bye.");
        }
    }//end main
}//end program