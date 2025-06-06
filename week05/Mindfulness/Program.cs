using System;


/*Exceeding requirements: .....*/

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