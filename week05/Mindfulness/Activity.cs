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

            Write("\nUpdating duration to minimum");
            ShowDotsLoading(3);
            Write($"\nSet to {_duration} seconds.");
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
        Write("How long, in seconds would you like your session to be? ");
        CheckDuration();


        Write("\nGet ready in... ");
        ShowCountDown(5);
    }

    public void DisplayEndingMessage()
    {
        Write("\n\nWell Done!! ");
        ShowDance(5);
    }

    public void ShowSpinner(int seconds)
    {
        GetSpinAnimationString();
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            //write the current spinner character
            Write(_list[index]);

            //speed of animation
            Thread.Sleep(750);  

            //erase it
            Write("\b\b \b");

            //move to next spinner character
            index = (index + 1) % _list.Count;
        }
    }

    public void ShowDance(int seconds)
    {
        GetDanceAnimationString();
        int spinnerIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string frame = _list[spinnerIndex];
            Write(frame);

            Thread.Sleep(750);

            // Move back to start of previous frame
            Write(new string('\b', frame.Length));

            spinnerIndex = (spinnerIndex + 1) % _list.Count;
        }

        // Clean ending
        Write(new string(' ', _list[0].Length));
        Write(new string('\b', _list[0].Length));
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            //write the next number
            Write($"{i} ");
            Thread.Sleep(1000);
            //erase the previous number
            if (i <= 9)
            {
                Write("\b\b \b");
            }
            else
            {
                Write("\b\b\b \b");
            }
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

    private void GetSpinAnimationString()
    {
        _list = new List<string>
        {
            "| ",
            "/ ",
            "— ",
            "\\ ",
        };
    }

    private void GetDanceAnimationString()
    {
        _list = new List<string>
        {
            "<('.'<) ",
            "(>'.')> ",
            "<('.')> "
        };
    }

    public DateTime GetEndTime()
    {
        DateTime startTime = DateTime.Now;
        return startTime.AddSeconds(GetDuration());
    }
}