public class ListingActivity : Activity
{
    //variables
    private List<string> _list;
    private Random _random = new Random();

    //create a default variables so that when a new object is created these items do not explicitly need to be called
    private const string DefaultDescription =
    "This activity will help you reflect on the good things in your life," +
    "\nThe minimum duration for this activity is 30 seconds." +
    "\nThis can be done by having you list as many things as you can under a certain topic.";
    public const string DefaultName = "Listing";
    private const int DefaultDuration = 30;

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
        ShowSpinner(7);

        GetRandomPrompt();
        //pause duration goes here

        GetListFromUser();
        //pause duration goes here
        //display number of items listed

        //method inherited from Activity class
        DisplayEndingMessage();
        //pause duration goes here
    }
    public void GetRandomPrompt()
    {
        //get list
        GetPromptList();
        // use random index from list
        int index = _random.Next(_list.Count);
        //return prompt
        Console.WriteLine(_list[index]);
    }

    public List<string> GetListFromUser()
    {
        //get user input and place in list
        return _list;
    }

    //prompts specific to the listing Activity class
    private void GetPromptList()
    {
        _list = new List<string>
        {
            "",
        };
    }


}