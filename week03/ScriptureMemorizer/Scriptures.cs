
/// <summary>
/// This class is the scripture
/// </summary>
class Scripture
{
    //variables
    private References _references = new References();
    private List<Word> words = new List<Word>();
    private string _text;

    //constructors
    //default constructor - constructors don't have return types
    public Scripture()
    {

    }

    public Scripture(References references, string text)
    {
        _references = references;
        _text = text;

    }

    //methods
    //hide words at random from the displayed scripture
    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}