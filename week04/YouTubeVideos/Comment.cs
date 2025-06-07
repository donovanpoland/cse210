public class Comment
{
    //variables
    private string _name;
    private string _text;

    //constructors
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    //methods
    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }
}