


/// <summary>
/// this class holds the references to a scripture
/// </summary>
class References
{
    //variables
    private int _endVerse;
    private string _book;
    private int _chapter;
    private int _verse;


    //constructors
    //default constructor - constructors don't have return types
    public References()
    {

    }

    /// <summary>
    /// References to the book, chapter and verse (if only 1) of a scripture 
    /// </summary>
    /// <param name="book"></param>
    /// <param name="chapter"></param>
    /// <param name="verse"></param>
    public References(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    /// <summary>
    /// References to the book, chapter staring verse and ending verse of a scripture 
    /// </summary>
    /// <param name="book"></param>
    /// <param name="chapter"></param>
    /// <param name="startVerse"></param>
    /// <param name="endVerse"></param>
    public References(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //methods
    public string GetDisplayText()
    {
        return "";
    }


}