using static System.Console;

public class BreathingActivity : Activity
{
    //create a default variables so that when a new object is created these items do not explicitly need to be called
    private const string DefaultName = "Breathing";
    private const string DefaultDescription =
    "This activity will help you relax by walking you through breathing in and out slowly." +
    "\nThe minimum duration for this activity is 36 seconds." +
    "\nClear your mind and focus on your breathing.";
    private const int DefaultDuration = 36;


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
        ShowSpinner(10);
    }

    public void AlternateBreath()
    {
        Clear();
        //total time per inhale + exhale (6+6 seconds)
        int breathDuration = 12; 
        int halfBreath = breathDuration / 2;

        //get start and end time for activity
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Write("\n\nbreath in");
            ShowDotsLoading(halfBreath);
            Write("\n\nbreath out");
            ShowDotsLoading(halfBreath);
        }
    }
}