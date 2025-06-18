public class Cycling : Activity
{
    private double _speed;

    public Cycling(double minutes, double speed) : base(minutes, "Cycling")
    {
        _speed = speed;
    }


    //distance in miles
    public override double CalculateDistance()
    {
        return Math.Round(_speed * _minutes / 60, 2);
    }

    //distance must be in miles
    //duration must be in minutes
    public override double CalculateSpeed()
    {
        return Math.Round(_speed, 2);
    }

    //minutes per mile
    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        return Math.Round(_minutes / distance, 2);
    }
}//end class