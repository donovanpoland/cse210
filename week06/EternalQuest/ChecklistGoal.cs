public class ChecklistGoal : Goal
{
    //variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //constructors
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = target;
    }

    //methods
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
    
    public override string GetDetailsString()
    {
        return "";
    }
}