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
        if (_entries.Count > 0)
        {
            WriteLine("\nPlease save current entry before adding a new one.");
        }
        else
        {
            newEntry.DisplayPrompt();
            _entries.Add($"Date: {newEntry._date} - Entry number: {newEntry._entryNumber}\n" +
            $"Prompt: {newEntry._promptText}\n{newEntry._entryText}\n--");
        }
    }
    public void DisplayUnsavedEntries()
    {
        //check if list is empty
        if (_entries.Count == 0)
        {
            WriteLine("\nNo new entries found.");
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
        if (_entries.Count == 0)
        {
            WriteLine("\nNothing to save.");
        }
        else
        {
            string journalEntries = "JournalEntries.txt";

            //second parameter append = true for adding to the file instead of overwriting it
            using (StreamWriter save = new StreamWriter(journalEntries, append: true))
            {
                foreach (string entry in _entries)
                {
                    save.WriteLine(entry);
                }
            }

            if (_entries.Count == 1)
            {
                //save current entry number
                _entry.SaveEntryNumber(_entry._entryNumber);
            }

            //empty string so the same entry is not saved multiple times
            _entries.Clear();
        }
    }
    public void LoadFromFile()
    {
        string journalEntries = "JournalEntries.txt";
        if (File.Exists(journalEntries))
        {
            string[] lines = File.ReadAllLines(journalEntries);

            if (lines.Length == 0)
            {
                WriteLine("\nJournal file is empty. Start by creating an entry.");
                return;//exit method if nothing in the file
            }

            string fullEntry = "";

            foreach (string line in lines)
            {
                if (line.Trim() == "--")
                {
                    WriteLine(fullEntry.Trim());
                    // show with separator
                    WriteLine(new string('-', 40));  
                    fullEntry = "";  // reset for next entry
                }
                else
                {
                    fullEntry += line + "\n";
                }
            }
        }
        else
        {
            WriteLine("\nNo journal file found. Start by creating an entry.");
        }
    }
    public void Menu()
    {

        WriteLine("\nPlease Select one of the following choices in either number or word form:");
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