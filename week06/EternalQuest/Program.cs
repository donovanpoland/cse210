using System;
using System.Drawing;

/*
Exceed requirements separated completed from uncompleted goals, added timers to make the menu more interactive.
added back up method for file incase user forgets to save. 
*/


class Program
{
    static void Main(string[] args)
    {
        Timers timer = new Timers();
        GoalManager menu = new GoalManager();

        Console.Clear();

        while (!menu.IsEnd())
        {
            menu.RestoreGoalsFromBackupIfNeeded();
            menu.Start();
        }
    }
}