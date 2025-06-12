public class SimpleGoal : Goal
{

    //variables
    private bool _isComplete;


    //constructors
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        //left blank due to inheritance
    }

    //methods
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return GetDetailsString();
    }
}