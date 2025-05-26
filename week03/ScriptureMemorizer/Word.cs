

public class Word
{
    //variables
    private string _text;
    private bool _isHidden;

    //constructors
    //no default constructor


    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public void ShowWord()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        //check for null
        if (string.IsNullOrEmpty(_text))
        {
            return "";
        }
        //check if hidden
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}