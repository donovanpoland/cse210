public class ListingActivity : Activity
{
    //variables
    private List<string> _list;
    private Random _random = new Random();

    //create a default description so that when a new object is created a description of this activity is not needed
    private const string DefaultDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    //constructor
    public ListingActivity(string name, int duration)
    : base(name, DefaultDescription, duration)
    {

    }

    //constructor for use if custom activity description is needed
    public ListingActivity(string name, string description, int duration)
    : base(name, description, duration)
    {

    }

    //methods
    public void Run()
    {
        //method inherited from Activity class
        DisplayStartingMessage();
        //pause duration goes here

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