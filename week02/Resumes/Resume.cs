public class Resume
{

    // Member variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Default Constructor
    public Resume()
    {
        
    }

    // Method to display Resume info
    public void DisplayResume()
    {
        Console.WriteLine($"{_name}\nJobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }





}