using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager menu = new GoalManager();

        while (!menu.IsEnd())
        {
            menu.Start();
        }
    }
}