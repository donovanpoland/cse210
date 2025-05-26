using System;
using System.Globalization;


/*Exceeding requirements.
    displays random scriptures loaded from a file. 
    loops through the menu asking if you want to use the same scripture and reset it back to visible.
    can get a a new scripture if the one displayed is not one you want to memorize or your done memorizing it.
    prevented preemptive/accidental quitting by hitting enter to many times.
*/

class Program
{
    static void Main(string[] args)
    {

        //get the scripture and the verse(s) from a file
        ScriptureStorage storage = new ScriptureStorage("scriptures.txt");
        var (reference, verseText) = storage.GetRandomScripture();
        Scripture scripture = new Scripture(reference, verseText);
        Console.WriteLine(scripture.GetScripture());
        int difficulty = 3;

        while (true)
        {
            Console.WriteLine(scripture.GetScripture());
            Console.Write("\nPress Enter to hide words, type 'reset', 'new', or 'quit': ");
            string input = Console.ReadLine()?.ToLower();

            string result = HandleUserInput(input, scripture);

            if (result == "quit")
                break;//end program / end loop

            if (result == "new")
            {
                var (newRef, newText) = storage.GetRandomScripture();
                scripture = new Scripture(newRef, newText);
                continue;
            }
            if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWords(difficulty);
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine(scripture.GetScripture());
                Console.WriteLine("\nYou've hidden all the words! Type 'reset' to review, 'new' for another scripture, or 'quit' to exit.");

                while (true)
                {
                    string postInput = Console.ReadLine()?.ToLower();

                    if (postInput == "quit")
                        return;

                    if (postInput == "reset")
                    {
                        scripture.ShowAllWords();
                        break; // continue the main loop
                    }

                    if (postInput == "new")
                    {
                        var (newRef, newText) = storage.GetRandomScripture();
                        scripture = new Scripture(newRef, newText);
                        break;
                    }
                    if (string.IsNullOrEmpty(input))
                    {
                        scripture.HideRandomWords(difficulty);
                    }

                    Console.WriteLine("Please type 'reset', 'new', or 'quit'.");
                }

                continue;
            }//end condition
        }//end loop
    }//end main method

    private static string HandleUserInput(string input, Scripture scripture)
    {
        switch (input)
        {
            case "quit":
                return "quit"; // signal to break the loop

            case "reset":
                scripture.ShowAllWords();
                return "continue"; // don't break, just reset and continue

            case "new":
                return "new";

            default:
                return "continue";//end switch
        }//end switch
    }//end input method
}//end program
