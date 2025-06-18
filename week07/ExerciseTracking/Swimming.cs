
public class Swimming : Activity
{

    //variables
    private double _laps;

    //converts meters to miles
    private const double METERS_TO_MILES = 0.00062;
    //length of a lap in the lap pool is 50 meters
    private const double POOL_LENGTH = 50;//meters

    //constructors
    public Swimming(double minutes, double laps) : base(minutes, "Swimming")
    {
        _laps = laps;
    }


    //distance in miles
    public override double CalculateDistance()
    {
        return Math.Round(_laps * POOL_LENGTH * METERS_TO_MILES, 2);
    }

    //distance must be in miles
    //duration must be in minutes
    public override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        return Math.Round(distance / _minutes * 60, 2);
    }

    //minutes per mile
    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        return Math.Round(_minutes / distance, 2);
    }
}//end class