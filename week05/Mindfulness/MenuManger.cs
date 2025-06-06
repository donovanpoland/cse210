using static System.Console;

public class MenuManager
{

    private bool _quit = false;

    public void ShowMenu()
    {
        Clear();
        WriteLine("\nPlease Select one of the following Activities:");
        WriteLine("1. Start Breathing Activity");
        WriteLine("2. Start Reflecting Activity");
        WriteLine("3. Start Listing ACtivity");
        WriteLine("4. Quit");
        Write("What would you like to do? ");
        //get choice, change to lowercase and trim white space
        string choice = ReadLine().ToLower().Trim();

        switch (choice)
        {
            case "1":
            case "breathing":
            case "breath":
                BreathingActivity breath = new BreathingActivity();
                breath.Run();
                break;

            case "2":
            case "reflect":
            case "reflection":
                ReflectionActivity reflect = new ReflectionActivity();
                reflect.Run();
                break;

            case "3":
            case "listing":
            case "list":
                ListingActivity list = new ListingActivity();
                list.Run();
                break;

            case "4":
            case "quit":
                Clear();
                WriteLine("Goodbye!");
                _quit = true;
                break;

            default:
                WriteLine("Invalid option. Try again.");
                ShowMenu();
                break;
        }
    }

    public bool ShouldQuit()
    {
        return _quit;
    }
}