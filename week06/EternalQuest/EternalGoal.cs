public class EternalGoal : Goal
{
    //constructors
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        //left blank due to inheritance
    }
    
        //methods
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}