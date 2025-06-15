using static System.Console;
public abstract class Goal
{

    //variables
    protected string _shortName;
    protected string _description;
    protected string _points;

    //constructors
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //methods
    public abstract void RecordEvent();


    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {

        string checkBox;
        if (IsComplete() == true)
        {
            checkBox = "[x]";
        }
        else
        {
            checkBox = "[]";
        }

        
        //convert first letters to capital for display
        return $"{checkBox} - Name: {CapitalizeFirst(_shortName)} - Desc: {CapitalizeFirst(_description)} - Points: {_points}";
    }

    private string CapitalizeFirst(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        return char.ToUpper(input[0]) + input.Substring(1);
    }

    public abstract string GetStringRepresentation();


    public abstract int GetPoints();


}