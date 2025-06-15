public class EternalGoal : Goal
{
    private int _timesCompleted = 0;
    // Constructors
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        // Left blank due to inheritance
    }

    // Methods
    public override void RecordEvent()
    {
        _timesCompleted++;
        Console.WriteLine($"Eternal goal \"{_shortName}\" recorded. +{_points} points");
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete
        return false; 
    }

    // public int GetTimesCompleted()
    // {
    //     return _timesCompleted;
    // }

    public void SetTimesCompleted(int count)
    {
        _timesCompleted = count;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal - Name: {_shortName} - Desc: {_description} - Points: {_points} - Completed: {_timesCompleted}";
    }
    
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} Completed: {_timesCompleted}";
    }
    
    public override int GetPoints()
    {
        // Can always get points
        return int.Parse(_points);
    }

}