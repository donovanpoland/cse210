using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Donovan", "CSE210");
        Console.WriteLine($"{assignment.GetSummary()}\n");


        MathAssignment math1 = new MathAssignment("Donovan Poland", "Math", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine($"{math1.GetHomeworkList()}\n");

        WritingAssignment wrt1 = new WritingAssignment("Donovan Poland", "Writing", "The Causes of World War II");
        Console.WriteLine(wrt1.GetSummary());
        Console.WriteLine($"{wrt1.GetWritingInformation()}\n");
    }
}