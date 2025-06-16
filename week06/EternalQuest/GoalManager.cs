using static System.Console;
using System.IO;

public class GoalManager
{
    //variables
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private bool _end = false;
    private Timers timer = new Timers();
    private int _unsavedScore;



    //constructor
    public GoalManager()
    {

    }

    //methods
    public void Start()
    {
        Clear();
        timer.Loading();
        CalculateScoreOnStart();
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
                    Clear();
                    Write("\nNo Goals to save.");
                    timer.ShowDotsLoading(3);
                }
                break;

            case "4":
            case "current":
                if (!ConfirmProceedIfUnsavedGoals())
                {
                    return;
                }
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
                if (!ConfirmProceedIfUnsavedGoals())
                {
                    return;
                }
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
                if (!ConfirmProceedIfUnsavedGoals())
                {
                    return;
                }
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
        if (_goals.Count > 0)
        {
            WriteLine("Press Enter to continue.");
            foreach (Goal goal in _goals)
            {
                WriteLine(goal.GetDetailsString());
            }
            ReadLine();
        }
        else
        {
            Clear();
            Write("\nNo goals to list. Create or load one first.");
            timer.ShowDotsLoading(3);
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
            Clear();
            Write("\nNo goals to record. Create or load one first.");
            timer.ShowDotsLoading(3);
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
            _unsavedScore += pointsEarned;
            Clear();
            Write($"\nYou earned {pointsEarned} points! Total score: {_score} ");
            timer.ShowDotsLoading(4);
        }
        else
        {
            WriteLine("Invalid choice.");
        }
    }

    public void SaveGoals()
    {
        _unsavedScore = 0;
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
                    //add points
                    _score += timesCompleted * eternal.GetPoints();
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
                    //add points
                    _score += amountCompleted * checklist.GetPoints();
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
                    //add points
                    _score += simple.GetPoints();
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
                    //add points
                    _score += amountCompleted * checklist.GetPoints();
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
            Write("It looks like you have unsaved work. Restore from backup? (yes/no)");
            string choice = ReadLine().ToLower().Trim();
            if (choice == "yes")
            {
                File.Copy("goals_backup.txt", "goals.txt", overwrite: true);
                LoadGoals();
            }
        }//if condition is not met nothing happens

        if (_goals.Count == 0 && File.Exists("completed_goals_backup.txt"))
        {
            Write("Restore completed goals from backup? (yes/no)");
            string choice = ReadLine().ToLower().Trim();
            if (choice == "yes")
            {
                File.Copy("completed_goals_backup.txt", "completed_goals.txt", overwrite: true);
                LoadCompletedGoals();
            }
        }//if condition is not met nothing happens
    }

    public void CalculateScoreOnStart()
    {
        _score = 0 + _unsavedScore;

        // Handle active goals
        if (File.Exists("goals.txt"))
        {
            foreach (string line in File.ReadAllLines("goals.txt"))
            {
                AddScoreFromLine(line);
            }
        }

        if (File.Exists("goals_backup.txt"))
        {
            foreach (string line in File.ReadAllLines("goals_backup.txt"))
            {
                AddScoreFromLine(line);
            }
        }

        // Handle completed goals
        if (File.Exists("completed_goals.txt"))
        {
            foreach (string line in File.ReadAllLines("completed_goals.txt"))
            {
                AddScoreFromLine(line);
            }
        }

        if (File.Exists("completed_goals_backup.txt"))
        {
            foreach (string line in File.ReadAllLines("completed_goals_backup.txt"))
            {
                AddScoreFromLine(line);
            }
        }
    }
    
    private void AddScoreFromLine(string line)
{
    string[] parts = line.Split(" - ");
    string type = parts[0];

    switch (type)
    {
        case "SimpleGoal":
            bool isComplete = bool.Parse(parts[4].Split("Completed: ")[1]);
            if (isComplete)
            {
                int points = int.Parse(parts[3].Split("Points: ")[1]);
                _score += points;
            }
            break;

        case "ChecklistGoal":
            int checklistPoints = int.Parse(parts[3].Split("Points: ")[1]);
            int target = int.Parse(parts[4].Split("Target: ")[1]);
            int bonus = int.Parse(parts[5].Split("Bonus: ")[1]);
            int completed = int.Parse(parts[6].Split("Completed: ")[1]);

            _score += checklistPoints * completed;
            if (completed >= target)
            {
                _score += bonus;
            }
            break;

        case "EternalGoal":
            int eternalPoints = int.Parse(parts[3].Split("Points: ")[1]);
            int timesCompleted = int.Parse(parts[4].Split("Completed: ")[1]);
            _score += eternalPoints * timesCompleted;
            break;
    }
}
}//end class