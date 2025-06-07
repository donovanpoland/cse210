using static System.Console;

public class ListingActivity : Activity
{
    //variables
    private List<string> _list;
    private Random _random = new Random();

    //create a default variables so that when a new object is created these items do not explicitly need to be called
    private const string DefaultDescription =
    "This activity will help you reflect on the good things in your life," +
    "\nThe minimum duration for this activity is 15 seconds." +
    "\nThis can be done by having you list as many things as you can under a certain topic.";
    public const string DefaultName = "Listing";
    private const int DefaultDuration = 15;

    //constructor
    public ListingActivity()
    //variables inherited from Activity class
    : base(DefaultName, DefaultDescription, DefaultDuration)
    {
    }

    //methods
    public void Run()
    {
        //method inherited from Activity class
        DisplayStartingMessage();

        Listing();

        //method inherited from Activity class
        DisplayEndingMessage();
    }
    private void GetRandomPrompt()
    {
        //get list
        GetPromptList();
        // use random index from list
        int index = _random.Next(_list.Count);
        //return prompt
        WriteLine(_list[index]);
    }

    private List<string> GetListFromUser(int seconds)
    {
        _list = new List<string>();
        string input;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            // Check if time has expired
            if (DateTime.Now >= endTime)
            {
                break;
            }
            input = ReadLine().Trim();
            _list.Add(input);
            Thread.Sleep(100);
        }

        return _list;
    }

    //prompts specific to the listing Activity class
    private void GetPromptList()
    {
        _list = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }

    private void Listing()
    {
        Clear();
        DateTime endTime = GetEndTime();

        while (DateTime.Now < endTime)
        {
            GetRandomPrompt();
            Write("\nStart listing in... ");
            ShowCountDown(10);
            GetListFromUser(GetDuration());
            Write("\nSaving list");
            ShowDotsLoading(3);
            Clear();
            DisplayList();
        }
    }

    private void DisplayList()
    {
        foreach(string listItem in _list)
        WriteLine(listItem);
    }

}