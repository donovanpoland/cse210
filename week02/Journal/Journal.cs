/*So I don't have to type console every time I need to use it.*/
using static System.Console;

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
    public void addEntry(Entry entry)
    {
        entry = _entry;

    }
    public void displayUnsavedEntries()
    {
        
    }
    public void saveToFile()
    {
        
    }
    public void loadFromFile()
    {
        
    }

    public void Menu()
    {

        WriteLine("Please Select one of the following choices");
        WriteLine("1. Write");
        WriteLine("2. Display");
        WriteLine("3. Load");
        WriteLine("4. Save");
        WriteLine("5. Quit");
        WriteLine("What would you like to do?");
        //get choice, change to lowercase and trim white space
        string choice = ReadLine().ToLower().Trim();

        switch (choice)
        {
            case "1":
            case "write":
                // handle write
                addEntry(_entry);
                break;

            case "2":
            case "display":
                // display current unsaved entries
                displayUnsavedEntries();
                break;

            case "3":
            case "load":
                // handle load
                loadFromFile();
                break;

            case "4":
            case "save":
                // handle save
                saveToFile();
                break;

            case "5":
            case "quit":
                WriteLine("Good Bye.");
                _quit = true;
                break;

            default:
                WriteLine("Invalid choice. Please enter a valid command.");
                break;
        }//end switch
    }//end method
}//end class