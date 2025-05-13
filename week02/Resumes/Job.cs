public class Job
{
    // Member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Default Constructor
    public Job()
    {
        
    }

    // Method to display job info
    public void DisplayJobDetails()
    {
        
        Console.WriteLine($"{_jobTitle} at {_company} {_startYear}-{_endYear}");
    }

}