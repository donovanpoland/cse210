using System;
/*So I don't have to type console every time I need to use it.*/
using static System.Console;

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