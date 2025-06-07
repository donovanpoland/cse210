using static System.Console;

public class BreathingActivity : Activity
{
    //create a default variables so that when a new object is created these items do not explicitly need to be called
    private const string DefaultName = "Breathing";
    private const string DefaultDescription =
    "This activity will help you relax by walking you through breathing in and out slowly." +
    "\nThe minimum session duration for this activity is 12 seconds." +
    "\nClear your mind and focus on your breathing.";
    private const int DefaultDuration = 12;


    //constructor
    public BreathingActivity()
    //variables inherited from Activity class
    : base(DefaultName, DefaultDescription, DefaultDuration)
    {

    }

    //methods
    public void Run()
    {
        //method inherited from Activity class
        DisplayStartingMessage();

        AlternateBreath();

        //methods inherited from Activity class
        DisplayEndingMessage();
    }

    private void AlternateBreath()
    {
        Clear();
        //total time per inhale + exhale (6+6 seconds)
        int fullBreathDuration = 12; 
        int halfBreath = fullBreathDuration / 2;

        //get start and end time for activity
        DateTime endTime = GetEndTime();

        while (DateTime.Now < endTime)
        {
            Write("\n\nbreath in");
            ShowDotsLoading(halfBreath);
            if (DateTime.Now >= endTime)
            {
                Write("\n\nbreath out");
                break;
            }
            Write("\n\nbreath out");
            ShowDotsLoading(halfBreath);
        }
    }
}