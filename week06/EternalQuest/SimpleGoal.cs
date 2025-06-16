public class SimpleGoal : Goal
{

    //variables
    private bool _isComplete;


    //constructors
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    //methods
    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Goal \"{_shortName}\" marked complete! +{_points} points");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    //for loading from a file
    public void SetComplete(bool value)
    {
        _isComplete = value;
    }

    public override string GetStringRepresentation()
    {
            return $"SimpleGoal - Name: {_shortName} - Desc: {_description} - Points: {_points} - Completed: {_isComplete}";
    }

    public override int GetPoints()
    {
        if (!_isComplete)
        {
            return int.Parse(_points);
        }
        else
        {
            return 0;
        }
    }
}