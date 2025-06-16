using static System.Console;
public class Timers
{
    //variables
    private List<string> _list;

    //constructors
    public Timers()
    {

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
        WriteLine("");
    }

    public void Loading()
    {
        GetLoadingString();

        string loadingText = "";
        foreach (string letter in _list)
        {
            loadingText += letter;
            Write(loadingText);
            Thread.Sleep(250);
            Write("\r"); 
        }
    }

    private void GetSpinAnimationString()
    {
        _list = new List<string>
        {
            "| ",
            "/ ",
            "— ",
            "\\ "
        };
    }
    
    private void GetLoadingString()
    {
        _list = new List<string>
        {
            "L",
            "O",
            "A",
            "D",
            "I",
            "N",
            "G",
            " ",
            "M",
            "E",
            "N",
            "U",
            ".",
            ".",
            "."
        };
    }


}