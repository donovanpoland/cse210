using System.Data;
using static System.Console;

public class GoalManager
{
    //variables
    private List<GoalManager> _goal;
    private int _score;
    private bool _end = false;


    //constructor
    public GoalManager()
    {

    }

    //methods
    public void Start()
    {
        Clear();
        DisplayPlayerInfo();

        WriteLine("\nMenu Options:");
        WriteLine("1. Create New Goal");
        WriteLine("2. List Goals");
        WriteLine("3. Save Goals");
        WriteLine("4. Load Goals");
        WriteLine("5. Record Event");
        WriteLine("6. Quit");
        Write("What would you like to do? ");
        //get choice, change to lowercase and trim white space
        string choice = ReadLine().ToLower().Trim();

        switch (choice)
        {
            case "1":
            case "create":
            case "new":
                CreateGoal();
                break;

            case "2":
            case "list":
            case "goals":
                ListGoalDetails();
                break;

            case "3":
            case "save":
                SaveGoals();
                break;

            case "4":
            case "load":
                LoadGoals();
                break;

            case "5":
            case "record":
            case "event":
                RecordEvent();
                break;

            case "6":
            case "quit":
                Clear();
                WriteLine("Goodbye!");
                _end = true;
                break;

            default:
                Clear();
                WriteLine("Invalid option. Try again.");
                Start();
                break;
        }
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {
        WriteLine("\nThe types of Goals are: ");
        WriteLine("1. Simple Goal");
        WriteLine("2. Eternal Goal");
        WriteLine("3. Checklist Goal");
        WriteLine("4. Nothing");
        Write("What type of goal would you like to create? ");
        //get choice, change to lowercase and trim white space
        string choice = ReadLine().ToLower().Trim();

        switch (choice)
        {
            case "1":
            case "one":
            case "simple":
                //go to simple Goal class
                break;

            case "2":
            case "two":
            case "eternal":
            case "forever":
                //go to Eternal Goal class
                break;

            case "3":
            case "three":
            case "checklist":
            case "list":
                //go to checklist Goal class
                break;

            case "4":
            case "four":
            case "no":
            case "nothing":
            case "back":
            case "go back":
                Clear();
                Start();
                break;

            default:
                Clear();
                WriteLine("Invalid option. Try again.");
                ListGoalNames();
                break;
        }
    }

    public void ListGoalDetails()
    {
        
    }

    public void CreateGoal()
    {
        ListGoalNames();
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }

    public bool IsEnd()
    {
        return _end;
    }

}//end class