
/// <summary>
/// 
/// </summary>
public class Word
{
    //variables
    private string _text;
    private bool _isHidden;

    //constructors
    //default constructor - constructors don't have return types
    public Word()
    {

    }

    /// <summary>
    /// Constructor for calling text and if that text is hidden or not
    /// </summary>
    /// <param name="text"></param>
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    /// <summary>
    /// Hide word
    /// </summary>
    public void HideWord()
    {
        _isHidden = true;
    }

    /// <summary>
    /// Show word
    /// </summary>
    public void ShowWord()
    {
        _isHidden = false;
    }

    /// <summary>
    /// check if word is hidden
    /// </summary>
    /// <returns> if hidden is true or false </returns>
    public bool IsHidden()
    {
        return _isHidden;
    }

    
    public string GetDisplayText()
    {
        return "";
    }
}