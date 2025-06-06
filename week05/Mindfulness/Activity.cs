using static System.Console;

public class Activity
{
    //variables
    protected string _name;
    protected string _description;
    private int _duration;
    private List<string> _list;



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
    private void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    private void CheckDuration()
    {
        //set duration to user input and convert to int
        int userDuration = int.Parse(ReadLine());
        if (userDuration < _duration)
        {
            Clear();
            // Set to default/minimum (already stored in _duration)
            SetDuration(_duration);

            Console.Write("\nUpdating duration to minimum");
            ShowDotsLoading(3);
            Console.Write($"\nSet to {_duration} seconds.");
            ShowDotsLoading(3);
        }
        else
        {
            SetDuration(userDuration);
        }
    }

    public void DisplayStartingMessage()
    {
        Clear();
        WriteLine($"Welcome to {_name} Activity.\n");
        WriteLine($"{_description}\n");
        Write("How long, in seconds would you like your session? ");
        CheckDuration();


        Write("\nGet ready in... ");
        ShowCountDown(5);
    }

    public void DisplayEndingMessage()
    {
        Write("\n\nWell Done!! ");
    }

    public void ShowSpinner(int seconds)
    {
        GetAnimationString();

        foreach (string s in _list)
        {
            Write(s);
            Thread.Sleep(1000);
            Write("\b\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            //write the next number
            Write($"{i} ");
            Thread.Sleep(1000);
            //erase the previous number
            Write("\b\b \b");
        }
    }

    public void ShowDotsLoading(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Thread.Sleep(1000);
            Write(".");
        }
    }

    private void GetAnimationString()
    {
        _list = new List<string>
        {
            "| ",
            "/ ",
            "- ",
            "\\ ",
        };
    }
}