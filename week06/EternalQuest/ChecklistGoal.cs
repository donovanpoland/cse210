public class ChecklistGoal : Goal
{
    //variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    //constructors
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
        _isComplete = false;
    }

    //methods
    public override void RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("Goal already completed!");
            return;
        }

        _amountCompleted++;
        Console.WriteLine($"Progress made on \"{_shortName}\"! ({_amountCompleted}/{_target}) +{_points} points");

        if (_amountCompleted >= _target)
        {
            _isComplete = true;
            Console.WriteLine($"Checklist complete! Bonus awarded: +{_bonus} points");
        }
    }

    //for loading from a file an setting state to complete
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
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
        return $"ChecklistGoal - Name: {_shortName} - Desc: {_description} - Points: {_points} - Target: {_target} - Bonus: {_bonus} - Completed: {_amountCompleted}";
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} Completion: {_amountCompleted}/{_target} Bonus: {_bonus}";
    }
    
    public override int GetPoints()
{
    if (_amountCompleted < _target)
    {
        //if the amount completed is more than target by 1 add bonus points
        if (_amountCompleted + 1 == _target)
            {
                return int.Parse(_points) + _bonus;
            }
        return int.Parse(_points);
    }
    return 0;
}

}