using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Timers timer = new Timers();
        GoalManager menu = new GoalManager();

        Console.Clear();
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine("Load current goals to see saved goals");
        Console.WriteLine("Load completed goals to see saved score\n");
        timer.Loading();

        menu.RestoreGoalsFromBackupIfNeeded();

        while (!menu.IsEnd())
        {
            menu.Start();
        }
    }
}