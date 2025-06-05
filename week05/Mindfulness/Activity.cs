using static System.Console;

public class Activity
{
    //variables
    private string _name;
    private string _description;
    private int _duration;

    private bool _quit = false;


    public Activity()
    {

    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //methods
    public void DisplayStartingMessage()
    {

    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }

    public void Menu()
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
                BreathingActivity breath = new BreathingActivity("Breathing", _duration);
                breath.Run();
                break;

            case "2":
            case "reflect":
            case "reflection":
                ReflectionActivity reflect = new ReflectionActivity("Reflection", _duration);
                reflect.Run();
                break;

            case "3":
            case "listing":
            case "list":
                ListingActivity list = new ListingActivity("Listing", _duration);
                list.Run();
                break;

            case "4":
            case "quit":
                WriteLine("Goodbye!");
                _quit = true;
                break;

            default:
                WriteLine("Invalid option. Try again.");
                Menu();
                break;
        }
    }

    public bool ShouldQuit()
    {
        return _quit;
    }
}