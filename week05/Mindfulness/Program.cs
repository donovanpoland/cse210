using System;

class Program
{
    static void Main(string[] args)
    {

        Activity activity = new Activity();

        while (!activity.ShouldQuit())
        {
            activity.Menu();
        }


    }
}