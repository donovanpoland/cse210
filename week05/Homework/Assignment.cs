public class Assignment
{
    //variables
    private string _studentName;
    private string _topic;

    //constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //methods
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string getStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
}