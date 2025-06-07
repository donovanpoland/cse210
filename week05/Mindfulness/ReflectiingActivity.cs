using static System.Console;

public class ReflectionActivity : Activity
{
    //variables
    private List<string> _list;
    private Random _random = new Random();

    //create a default variables so that when a new object is created these items do not explicitly need to be called
    private const string DefaultDescription =
    "This activity will help you reflect on times in your life when you have shown strength and resilience." +
    "\nThe minimum session duration for this activity is 15 seconds." +
    "\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
    public const string DefaultName = "Reflection";
    private const int DefaultDuration = 15;

    //constructor
    public ReflectionActivity()
    //variables inherited from Activity class
    : base(DefaultName, DefaultDescription, DefaultDuration)
    {
        //no extra code needed
    }

    //methods
    public void Run()
    {
        //method inherited from Activity class
        DisplayStartingMessage();

        Reflecting();

        //method inherited from Activity class
        DisplayEndingMessage();
    }

    private void Reflecting()
    {
        Clear();
        DateTime endTime = GetEndTime();

        while (DateTime.Now < endTime)
        {
            DisplayPrompt();
            ShowDotsLoading(5);
            if (DateTime.Now >= endTime)
            {
                break;
            }
            DisplayQuestion();
            ShowSpinner(10);
            WriteLine();
        }
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

    private void DisplayPrompt()
    {
        Write($"\n{GetRandomPrompt()}");
    }

    private void DisplayQuestion()
    {
        Write($"\n{GetRandomQuestion()} ");
    }

    private void GetPromptList()
    {
        _list = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you overcame fear to do the right thing.",
            "Recall a moment when you made a choice that changed your life.",
            "Think of a time when you forgave someone who hurt you.",
            "Remember a situation where you had to admit you were wrong.",
            "Think of a time when you showed kindness to someone who didn't expect it.",
            "Recall a moment when you learned something important about yourself.",
            "Think of a time when you pushed forward even when it was hard.",
            "Reflect on a moment that made you feel truly grateful.",
            "Think of a time when you felt deeply connected to another person.",
            "Recall a moment when you let go of something or someone with peace."
        };
    }

    private void GetQuestionList()
    {
        _list = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
}