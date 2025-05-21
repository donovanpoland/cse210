

class Entry
{
    //member variables
    public string _promptText;
    public string _date;
    public string _entryText;
    public int _entryNumber;


    //Default constructor
    public Entry()
    {

    }


    //methods
    public void DisplayPrompt()
    {
        //add new entry to entry count
        _entryNumber = LoadEntryCount() + 1;
        
        //check and get current date
        GetDate();
        //get new prompt for user
        GetPrompt();
        //display all info
        Console.WriteLine($"Date: {_date} - Entry number:{_entryNumber}\n" +
        $"Prompt: {_promptText}");
        //get user entry
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

    public void SaveEntryNumber(int count)
    {
        File.WriteAllText("EntryCount.txt", count.ToString());
    }

    public int LoadEntryCount()
    {
        string entryCount = "EntryCount.txt";

        if (File.Exists(entryCount))
        {
            string content = File.ReadAllText(entryCount);

            if (int.TryParse(content, out int count))
            {
                return count;
            }
        }

        return 0;
    }
}