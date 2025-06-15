using static System.Console;
using System.IO;

public class GoalManager
{
    //variables
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private bool _end = false;
    private Timers timer = new Timers();


    //constructor
    public GoalManager()
    {

    }

    //methods
    public void Start()
    {
        DisplayPlayerInfo();

        ListMainMenu();
        //get Menu choice, change to lowercase and trim white space
        string choice = ReadLine().ToLower().Trim();

        switch (choice)
        {
            case "1":
            case "create":
            case "new":
                Clear();
                CreateGoal();
                break;

            case "2":
            case "list":
            case "goals":
                Clear();
                ListGoalDetails();
                break;

            case "3":
            case "save":
                if (_goals.Count > 0)
                {
                    SaveGoals();
                    Clear();
                    Write("\nSaving");
                    timer.ShowDotsLoading(3);
                    Write("Goals saved successfully. ");
                    timer.ShowSpinner(4);
                    Clear();
                }
                else
                {
                    Write("No Goals to save.");
                    timer.ShowDotsLoading(3);
                }
                break;

            case "4":
            case "current":
                ConfirmProceedIfUnsavedGoals();
                LoadGoals();
                if (_goals.Count > 0)
                {
                    Clear();
                    timer.Loading();
                    Write("Current Goals successfully loaded. ");
                    timer.ShowSpinner(3);
                    Clear();
                }
                break;

            case "5":
            case "complete":
                ConfirmProceedIfUnsavedGoals();
                LoadCompletedGoals();
                if (_goals.Count > 0)
                {
                    Clear();
                    timer.Loading();
                    Write("Completed Goals successfully loaded. ");
                    timer.ShowSpinner(3);
                    Clear();
                }
                break;

            case "6":
            case "record":
            case "event":
                RecordEvent();
                if (_goals.Count > 0)
                {
                    Clear();
                    timer.Loading();
                    Write("Goal Updated successfully. Don't forget to save.");
                    timer.ShowSpinner(3);
                    Clear();
                }
                break;

            case "7":
            case "quit":
                ConfirmProceedIfUnsavedGoals();
                Clear();
                Write("Goodbye");
                timer.ShowDotsLoading(3);
                _end = true;
                break;

            default:
                Clear();
                Write("Invalid option. Try again.");
                timer.ShowDotsLoading(3);
                Start();
                break;
        }
    }

    public void DisplayPlayerInfo()
    {
        WriteLine($"Current Points: {_score}");
    }

    private void ListGoalNames()
    {
        WriteLine("\nThe types of Goals are: ");
        WriteLine("1. Simple Goal");
        WriteLine("2. Eternal Goal");
        WriteLine("3. Checklist Goal");
        WriteLine("4. Nothing");
        Write("What type of goal would you like to create? ");

    }

    public void ListMainMenu()
    {
        WriteLine("\nMenu Options:");
        WriteLine("1. Create New Goal");
        WriteLine("2. List Goals");
        WriteLine("3. Save Goals");
        WriteLine("4. Load Current Goals");
        WriteLine("5. Load Completed Goals");
        WriteLine("6. Record Event");
        WriteLine("7. Quit");
        Write("What would you like to do? ");
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        string choice;

        while (true)
        {
            ListGoalNames();
            //get choice, change to lowercase and trim white space
            choice = ReadLine().ToLower().Trim();

            if (IsValidGoalType(choice))
            {
                break; // valid goal type, break out of loop
            }

            Clear();
            Write("Invalid option. Try again.");
            timer.ShowDotsLoading(3);
            Clear();
        }

        //get input from user and return it if not empty
        string name = GetNonEmptyInput("\nWhat is the name of your Goal? ");
        string description = GetNonEmptyInput("What is a short description of it? ");
        string points = GetNonEmptyInput("What is the amount of points associated with this goal? ");

        //send input to
        switch (choice)
        {
            case "1":
            case "one":
            case "simple":
                //go to simple Goal class
                _goals.Add(new SimpleGoal(name, description, points));
                ShowCreating("Simple");
                break;

            case "2":
            case "two":
            case "eternal":
            case "forever":
                //go to Eternal Goal class
                _goals.Add(new EternalGoal(name, description, points));
                ShowCreating("Eternal");
                break;

            case "3":
            case "three":
            case "checklist":
            case "list":
                //go to checklist Goal class
                Write("How many times must this goal be completed for a bonus? ");
                int target = int.Parse(ReadLine().Trim());

                Write("What is the bonus for completing it that many times? ");
                int bonus = int.Parse(ReadLine().Trim());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                ShowCreating("Checklist");
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
                WriteLine("Unexpected error.");
                timer.ShowDotsLoading(3);
                break;
        }
    }

    private bool IsValidGoalType(string input)
    {
        return input == "1" || input == "one" || input == "simple"
            || input == "2" || input == "two" || input == "eternal" || input == "forever"
            || input == "3" || input == "three" || input == "checklist" || input == "list";
    }

    private string GetNonEmptyInput(string prompt)
    {
        string input;
        do
        {
            Write(prompt);
            input = ReadLine().Trim();

            if (string.IsNullOrEmpty(input))
            {
                Write("Input cannot be empty. Please try again.");
                timer.ShowDotsLoading(3);
                Clear();
            }

        } while (string.IsNullOrEmpty(input));

        return input;
    }

    private void ShowCreating(string type)
    {
        Clear();
        Write($"Creating {type} Goal");
        timer.ShowDotsLoading(4);
        Clear();
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            WriteLine("No goals to record. Create one first.");
            //end method
            return;
        }

        WriteLine("\nWhich goal did you complete?");
        for (int i = 0; i < _goals.Count; i++)
        {
            WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Write("\nEnter goal number: ");
        if (int.TryParse(ReadLine(), out int choice) && choice >= 1 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];
            int pointsEarned = selectedGoal.GetPoints();
            selectedGoal.RecordEvent();
            _score += pointsEarned;
            Clear();
            WriteLine($"\nYou earned {pointsEarned} points! Total score: {_score}");
        }
        else
        {
            WriteLine("Invalid choice.");
        }
    }

    public void SaveGoals()
    {
        if (_goals.Count == 0)
        {
            WriteLine("No goals to Save. Create one first.");
            //end method
            return;
        }
        // loads from "goals.txt"
        LoadGoals();
        // loads from "completed_goals.txt"
        LoadCompletedGoals();
        // Create new strings to hold the goals
        List<string> activeGoals = new List<string>();
        List<string> completedGoals = new List<string>();

        // Filter goals into correct strings
        foreach (Goal goal in _goals)
        {
            if (goal is EternalGoal eternal)
            {
                // always include
                activeGoals.Add(eternal.GetStringRepresentation()); 
            }
            else if (goal.IsComplete())
            {
                completedGoals.Add(goal.GetStringRepresentation());
            }
            else
            {
                activeGoals.Add(goal.GetStringRepresentation());
            }
        }

        //add goals to file
        File.WriteAllLines("goals.txt", activeGoals);
        File.WriteAllLines("completed_goals.txt", completedGoals);

        //clean up backup data
        if (File.Exists("goals_backup.txt")) File.Delete("goals_backup.txt");
        if (File.Exists("completed_goals_backup.txt")) File.Delete("completed_goals_backup.txt");

        //after save to file, clear lists to avoid saving duplicates
        completedGoals.Clear();
        activeGoals.Clear();
        _goals.Clear();
    }//end save method

    public void LoadGoals()
    {
        //create a string to hold all lines
        string[] lines = File.ReadAllLines("goals.txt");

        //check if file exists
        if (!File.Exists("goals.txt"))
        {
            WriteLine("No saved goals file found.");
            return;
        }//end condition

        foreach (string line in lines)
        {
            string[] parts = line.Split(" - ");
            //get the type of goal from index 0
            string type = parts[0];
            string name;
            string description;
            string points;
            bool isComplete;
            int target;
            int bonus;
            int amountCompleted;
            int timesCompleted;

            switch (type)
            {
                case "SimpleGoal":
                    //get parts
                    name = parts[1].Replace("Name: ", "").Trim();
                    description = parts[2].Replace("Desc: ", "").Trim();
                    points = parts[3].Replace("Points: ", "").Trim();
                    isComplete = parts.Length > 4 && bool.Parse(parts[4].Replace("Completed: ", "").Trim());

                    SimpleGoal simple = new SimpleGoal(name, description, points);
                    simple.SetComplete(isComplete);
                    _goals.Add(simple);
                    break;

                case "EternalGoal":
                    //get parts
                    name = parts[1].Replace("Name: ", "").Trim();
                    description = parts[2].Replace("Desc: ", "").Trim();
                    points = parts[3].Replace("Points: ", "").Trim();
                    timesCompleted = int.Parse(parts[4].Replace("Completed: ", "").Trim());

                    //create object
                    EternalGoal eternal = new EternalGoal(name, description, points);
                    eternal.SetTimesCompleted(timesCompleted);
                    _goals.Add(eternal);

                    //add up points
                    _score += eternal.GetPoints() * timesCompleted;
                    break;

                case "ChecklistGoal":
                    //get parts
                    name = parts[1].Replace("Name: ", "").Trim();
                    description = parts[2].Replace("Desc: ", "").Trim();
                    points = parts[3].Replace("Points: ", "").Trim();
                    target = int.Parse(parts[4].Replace("Target: ", "").Trim());
                    bonus = int.Parse(parts[5].Replace("Bonus: ", "").Trim());
                    amountCompleted = int.Parse(parts[6].Replace("Completed: ", "").Trim());

                    //create object
                    ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
                    checklist.SetAmountCompleted(amountCompleted);
                    _goals.Add(checklist);
                    break;
            }//end switch
        }//end foreach loop
        // Create backup
        File.Copy("goals.txt", "goals_backup.txt", overwrite: true);

        // Clear file after backing up
        File.WriteAllText("goals.txt", string.Empty);
    }//end method

    public void LoadCompletedGoals()
    {
        //create a string to hold all lines
        string[] lines = File.ReadAllLines("completed_goals.txt");

        //check if file exists
        if (!File.Exists("completed_goals.txt"))
        {
            WriteLine("No saved goals file found.");
            return;
        }//end condition

        _score = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split(" - ");
            //get the type of goal from index 0
            string type = parts[0];
            string name;
            string description;
            string points;
            bool isComplete;
            int target;
            int bonus;
            int amountCompleted;

            switch (type)
            {
                case "SimpleGoal":
                    //get parts
                    name = parts[1].Replace("Name: ", "").Trim();
                    description = parts[2].Replace("Desc: ", "").Trim();
                    points = parts[3].Replace("Points: ", "").Trim();
                    //should always be true
                    isComplete = parts.Length > 4 && bool.Parse(parts[4].Replace("Completed: ", "").Trim());

                    //create object
                    SimpleGoal simple = new SimpleGoal(name, description, points);
                    simple.SetComplete(isComplete);
                    _goals.Add(simple);

                    //add up points
                    _score += int.Parse(points);
                    break;

                // No eternal goals should be in this file.
                // case "EternalGoal":

                case "ChecklistGoal":
                    //get parts
                    name = parts[1].Replace("Name:", "").Trim();
                    description = parts[2].Replace("Desc:", "").Trim();
                    points = parts[3].Replace("Points:", "").Trim();
                    target = int.Parse(parts[4].Replace("Target:", "").Trim());
                    bonus = int.Parse(parts[5].Replace("Bonus:", "").Trim());
                    amountCompleted = int.Parse(parts[6].Replace("Completed:", "").Trim());

                    //create object
                    ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
                    checklist.SetAmountCompleted(amountCompleted);
                    _goals.Add(checklist);

                    //add up points
                    _score += int.Parse(points) * amountCompleted;
                    if (amountCompleted >= target)
                    {
                        _score += bonus;
                    }
                    break;
            }//end switch
        }//end foreach loop
        File.Copy("completed_goals.txt", "completed_goals_backup.txt", overwrite: true);
        File.WriteAllText("completed_goals.txt", string.Empty);
    }//end method

    public bool IsEnd()
    {
        return _end;
    }

    public bool ConfirmProceedIfUnsavedGoals()
    {
        if (_goals.Count > 0)
        {
            WriteLine($"\nYou have {_goals.Count} goals currently loaded.");
            WriteLine("If you proceed, any unsaved work may be lost.");
            Write("Are you sure you want to continue? (yes/no): ");
            string input = ReadLine().ToLower().Trim();

            while (input != "yes" && input != "no")
            {
                Write("Please type 'yes' or 'no': ");
                input = ReadLine().ToLower().Trim();
            }
            // proceed only if the user confirms
            return input == "yes";
        }
        // safe to proceed if no goals are loaded
        return true;
    }

    public void RestoreGoalsFromBackupIfNeeded()
    {
        if (_goals.Count == 0 && File.Exists("goals_backup.txt"))
        {
            WriteLine("It looks like you have unsaved work. Restore from backup? (yes/no)");
            string choice = ReadLine().ToLower().Trim();
            if (choice == "yes")
            {
                File.Copy("goals_backup.txt", "goals.txt", overwrite: true);
                LoadGoals();
            }
        }//if condition is not met nothing happens

        if (_goals.Count == 0 && File.Exists("completed_goals_backup.txt"))
        {
            WriteLine("Restore completed goals from backup? (yes/no)");
            string choice = ReadLine().ToLower().Trim();
            if (choice == "yes")
            {
                File.Copy("completed_goals_backup.txt", "completed_goals.txt", overwrite: true);
                LoadCompletedGoals();
            }
        }//if condition is not met nothing happens
    }

}//end class