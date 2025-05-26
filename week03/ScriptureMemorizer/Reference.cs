

public class Reference
{
    //variables
    private int _endVerse;
    private string _book;
    private int _chapter;
    private int _verse;


    //constructors
    //no default constructor

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;//default for unused variable
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //methods
    public string GetReference()
    {
        //check whether to display a verse range or single verse
        //(_endVerse != 0) = did not use single verse constructor
        if (_endVerse != 0 && _endVerse != _verse)
        {
            // This is a range of verses
            return $"{_book} {_chapter}: {_verse}-{_endVerse}";
        }
        else
        {
            // Single verse
            return $"{_book} {_chapter}: {_verse}";
        }
    }


}