
/// <summary>
/// This class is the scripture
/// </summary>
class Scripture
{
    //variables
    private References _references = new References();
    private List<Word> words = new List<Word>();
    private bool _endProgram = false;
    

    //constructors
    //default constructor - constructors don't have return types
    public Scripture()
    {

    }

    public Scripture(References references, string text)
    {
        _references = references;

    }

    //methods
    //hide words at random from the displayed scripture
    public void HideRandomWords(int numberToHide)
    {
        Random _random = new Random();
        // numberToHide;
        //hide new word

    }

    public string GetDisplayText()
    {
        Console.Clear();
        //display new scripture with hidden word in verse
        return "";
    }

    public bool IsCompletelyHidden()
    {
        _endProgram = true;
        return _endProgram;
    }
}