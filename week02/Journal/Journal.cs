/*So I don't have to type console every time I need to use it.*/
using static System.Console;
//for loading files
using System.IO;

class Journal
{
    //member variables
    List<string> _entries = new List<string>();
    Entry _entry = new Entry();

    public bool _quit = false;

    //Default constructor
    public Journal()
    {

    }


    //methods
    public void AddEntry(Entry newEntry)
    {
        newEntry.DisplayPrompt();
        _entries.Add($"Date: {newEntry._date} - Prompt: {newEntry._promptText}\n{newEntry._entryText}\n------");
    }

    public void DisplayUnsavedEntries()
    {
        //check if list is empty
        if (_entries.Count == 0)
        {
            WriteLine("\nNo entries found.");
        }
        else
        {
            foreach (string entry in _entries)
            {
                WriteLine($"\n{entry}");
            }
        }
    }
    public void SaveToFile()
    {
        string journalEntries = "JournalEntries.txt";

        using (StreamWriter save = new StreamWriter(journalEntries))
        {
            foreach (string entry in _entries)
            {
                save.WriteLine(entry);
            }
        }
    }
    public void LoadFromFile()
    {

    }

    public void Menu()
    {

        WriteLine("\nPlease Select one of the following choices");
        WriteLine("1. Write");
        WriteLine("2. Display");
        WriteLine("3. Load");
        WriteLine("4. Save");
        WriteLine("5. Quit");
        Write("What would you like to do? ");
        //get choice, change to lowercase and trim white space
        string choice = ReadLine().ToLower().Trim();

        switch (choice)
        {
            case "1":
            case "write":
                // handle write
                AddEntry(_entry);
                break;

            case "2":
            case "display":
                // display current unsaved entries
                DisplayUnsavedEntries();
                break;

            case "3":
            case "load":
                // handle load
                LoadFromFile();
                break;

            case "4":
            case "save":
                // handle save
                SaveToFile();
                break;

            case "5":
            case "quit":
                WriteLine("\nGood Bye.");
                _quit = true;
                break;

            default:
                WriteLine("\nInvalid choice. Please enter a valid command.");
                break;
        }//end switch
    }//end method
}//end class