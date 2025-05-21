using System;



/*Exceeding requirements: added an extra feature that keeps track of the number of entries
the user enters into the journal, this number saves when you save your entry to the entry file
in order to accomplish this I had to force the user to only save 1 entry at a time
instead of int baches, in a real program entries would be saved automatically and I would
not have to put this blocker on the number of entires at a time.

there is also about 30 prompts, so a user could possibly get a new prompt every day for a month*/


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();


        while (journal._quit == false)
        {
            journal.Menu();
        }
    }


}