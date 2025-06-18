public class Running : Activity
{
    private double _distance; // in miles

    public Running(double minutes, double distance) : base(minutes, "Running")
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return Math.Round(_distance, 2);
    }

    public override double CalculateSpeed()
    {
        return Math.Round(_distance / _minutes * 60, 2);
    }

    public override double CalculatePace()
    {
        return Math.Round(_minutes / _distance, 2);
    }
}