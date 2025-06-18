using System.Globalization;
using System.IO.Pipes;

public abstract class Activity
{


    //variables
    protected string _date;
    protected double _minutes;
    protected string _activityName;

    //constructors

    public Activity(double minutes, string activityName)
    {
        _date = DateTime.Now.ToString("dd MMM yyyy");
        _minutes = minutes;
        _activityName = activityName;
    }

    //methods

    //number of miles
    public abstract double CalculateDistance();

    //miles per hour
    public abstract double CalculateSpeed();

    //minutes per mile
    public abstract double CalculatePace();

    // get data in this form:
    // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
    // date, activity, duration(minutes), distance, speed, pace
    public virtual string GetSummary()
    {
        return $"{_date} {_activityName} ({_minutes}) Minutes - Distance {CalculateDistance()} Miles, Speed {CalculateSpeed()} Pace {CalculatePace()} Minutes per Mile";
    }





}