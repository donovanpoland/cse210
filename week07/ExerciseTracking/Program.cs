using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Swimming swimming = new Swimming(15, 32.29);
        Console.WriteLine(swimming.GetSummary());

        Cycling cycling = new Cycling(30, 20);
        Console.WriteLine(cycling.GetSummary());

        Running running = new Running(60, 7);
        Console.WriteLine(running.GetSummary());
    }
}