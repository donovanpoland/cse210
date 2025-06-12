public class Goal
{

    //variables
    private string _shortName;
    private string _description;
    private string _points;

    //constructors
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //methods
    public virtual void RecordEvent()
    {
        
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {

        string checkBox = "";
        if (IsComplete() == true)
        {
            checkBox = "[x]";
        }
        else
        {
            checkBox = "[]";
        }

        Console.Write("\nWhat is the name of your Goal? ");
        _shortName = Console.ReadLine().Trim();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine().Trim();
        Console.Write("What is the amount of points associated with this goal?");
        _points = Console.ReadLine().Trim();
        
        return $"{checkBox} {_shortName} {_description} {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return GetDetailsString();
    }






}