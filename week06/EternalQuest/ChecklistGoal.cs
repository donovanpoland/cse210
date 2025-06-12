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
        _bonus = bonus;
    }

    //methods
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public override string GetStringRepresentation()
    {
        return GetDetailsString();
    }
    
    public override string GetDetailsString()
    {
        return $"{ GetDetailsString()} {_target} {_bonus}";
    }
}