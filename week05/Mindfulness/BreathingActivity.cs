public class BreathingActivity : Activity
{

    //create a default description so that when a new object is created a description of this activity is not needed
    private const string DefaultDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    //constructor
    public BreathingActivity(string name, int duration)
    : base(name, DefaultDescription, duration)
    {

    }

    //constructor for use if custom activity description is needed
    public BreathingActivity(string name, string description, int duration)
    : base(name, description, duration)
    {

    }

    //methods
    public void Run()
    {
        //method inherited from Activity class
        DisplayStartingMessage();
        //pause duration goes here

        AlternateBreath();

        //method inherited from Activity class
        DisplayEndingMessage();
        //pause duration goes here
    }

    public void AlternateBreath()
    {
        
    }
}