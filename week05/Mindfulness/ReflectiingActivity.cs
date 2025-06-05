

public class ReflectionActivity : Activity
{
    //variables
    private List<string> _list;
    private Random _random = new Random();

    //create a default description so that when a new object is created a description of this activity is not needed
    private const string DefaultDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    //constructor
    public ReflectionActivity(string name, int duration)
    //variables inherited from Activity class
    : base(name, DefaultDescription, duration)
    {
        //no extra code needed
    }

    //constructor for use if custom activity description is needed
    public ReflectionActivity(string name, string description, int duration)
    //variables inherited from Activity class
    : base(name, description, duration)
    {
        //no extra code needed
    }

    //methods
    public void Run()
    {
        //method inherited from Activity class
        DisplayStartingMessage();
        //pause duration goes here

        DisplayPrompt();
        //pause duration goes here

        DisplayQuestion();
        //pause duration goes here

        //method inherited from Activity class
        DisplayEndingMessage();
        //pause duration goes here
    }

    private string GetRandomPrompt()
    {
        //get list
        GetPromptList();
        // use random index from list
        int index = _random.Next(_list.Count);
        //return prompt
        return _list[index];
    }

    private string GetRandomQuestion()
    {
        //get list
        GetQuestionList();
        // use random index from list
        int index = _random.Next(_list.Count);
        //return prompt
        return _list[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    //prompts specific to the Reflecting Activity class
    private void GetPromptList()
    {
        _list = new List<string>
        {
            "",
        };
    }

    private void GetQuestionList()
    {
        _list = new List<string>
        {
            "",
        };
    }
}