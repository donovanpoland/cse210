using System;


/*Exceeding requirements: added new animation (a little dancing face) when the activity is done.
    added extra logic to the timing of activities to ensure the time matches the the time given by the user
*/

class Program
{
    static void Main(string[] args)
    {

        MenuManager menu = new MenuManager();

        while (!menu.ShouldQuit())
        {
            menu.ShowMenu();
        }
    }
}