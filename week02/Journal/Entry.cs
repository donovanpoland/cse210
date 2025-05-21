

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
        getDate();
        getPrompt();
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        getUserEntry();
    }


    private void getDate()
    {
        DateTime today = DateTime.Now;
        _date = today.ToString("MM/dd/yyyy");
    }
    
    private void getPrompt()
    {
        PromptGenerator prompt = new PromptGenerator();
        _promptText = prompt.GetRandomPrompt();
    }

    private void getUserEntry()
    {
        _entryText = Console.ReadLine();
    }
}