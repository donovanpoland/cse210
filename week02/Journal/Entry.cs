

class Entry
{
    //member variables
    public string _promptText;
    public string _date;
    public string _entryText;


    //Default constructor
    public Entry()
    {

    }


    //methods
    public void DisplayPrompt()
    {
        GetDate();
        GetPrompt();
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        GetUserEntry();
    }


    private void GetDate()
    {
        DateTime today = DateTime.Now;
        _date = today.ToString("MM/dd/yyyy");
    }

    private void GetPrompt()
    {
        PromptGenerator prompt = new PromptGenerator();
        _promptText = prompt.GetRandomPrompt();
    }


    private void GetUserEntry()
    {
        _entryText = Console.ReadLine();
    }
}