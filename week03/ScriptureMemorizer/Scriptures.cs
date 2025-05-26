

class Scripture
{
    //variables
    private Reference _reference;
    private readonly List<Word> words = new List<Word>();

    //constructors
    //no default constructor

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] wordArray = text.Split(' ');

        foreach (string wordText in wordArray)
        {
            words.Add(new Word(wordText));
        }

    }

    //methods
    //hide words at random from the displayed scripture
    public void HideRandomWords(int numberToHide)
    {
        //create a new random number for later use
        Random random = new Random();

        //create a list of words that are not hidden
        List<Word> visibleWords = new List<Word>();

        //loop through each word in the words list
        foreach (Word word in words)
        {
            //check if word is not already hidden
            if (!word.IsHidden())
            {
                //add to list of visible words
                visibleWords.Add(word);
            }//end if
        }//end foreach loop

        // don't hide more words than are available
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        //loop through the words to hide
        for (int i = 0; i < wordsToHide; i++)
        {
            //choose a random index from the visible words list
            int index = random.Next(visibleWords.Count);
            //make word hidden
            visibleWords[index].HideWord();
            //remove from visible words list
            visibleWords.RemoveAt(index);
        }//end for loop
    }//end HideRandomWords method


    public string GetScripture()
    {
        //clear console
        Console.Clear();
        return _reference.GetReference() + "\n" + FormatScriptureText();
    }

    private string FormatScriptureText()
    {
        string formattedText = "";

        foreach (Word word in words)
        {
            formattedText += word.GetDisplayText() + " ";
        }

        return formattedText.TrimEnd(); // Remove trailing space
    }


    public bool IsCompletelyHidden()
    {
        //check if all words are hidden
        foreach (Word word in words)
        {
            //if there is a visible word
            //if a word is not hidden
            if (!word.IsHidden())
            {
                //found a visible word
                return false;
            }//end if
        }//end foreach loop

        //all words are hidden
        return true;
    }

    public void ShowAllWords()
    {
        foreach (Word word in words)
        {
            word.ShowWord();
        }
    }
}