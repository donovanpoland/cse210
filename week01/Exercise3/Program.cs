using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //Overview
        //      In the Guess My Number game the computer picks a magic number, and then the user tries to guess it.
        //      After each guess, the computer tells the user to guess "higher" or "lower" until they guess the magic number.

        //Step 1
        // // extended version - 3 lines (console output, store input, convert)
        // // ask user for magic number
        // Console.Write("\nWhat is the magic number? ");
        // // store user input
        // string userInput = Console.ReadLine();
        // // convert to number
        // float magicNumber = float.Parse(userInput);

        // generate a random number between 1 and 100
        Console.WriteLine("A random integer between 1 and 100 will be generated every round, guess the number and win.");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // shorter version - 2 lines
        // ask user to guess magic number
        Console.Write("What is your guess? ");
        // store user input and convert to number from user string
        float guess = float.Parse(Console.ReadLine());

        //store guess count
        int guessCount = 0;

        //define play again
        string playAgain = "yes";

        //set high score
        int highScore = 100;

        // check if guess is higher, lower or equal to the magic number
        // step 2 add loop
        while (playAgain == "yes")
        {
            do
            {
                //every guess will add to guess counter
                guessCount += 1;
                // compare guess to magic number
                if (guess >= 1 && guess <= 100)
                {
                    //nested if statement
                    //check if higher or lower - guess again
                    if (guess > magicNumber)
                    {
                        Console.WriteLine("Nope, guess lower.");
                        Console.Write("What is your new guess? ");
                        guess = float.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Nope, guess higher.");
                        Console.Write("What is your new guess? ");
                        guess = float.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    //wrong numbers count as another guess
                    Console.Write("That is not a number between 1 and 100, please try again. ");
                    guess = float.Parse(Console.ReadLine());
                }// exit nested if statement
            } while (guess != magicNumber); //end do while loop
            Console.Write($"Correct! The magic number was {magicNumber}. You guessed the magic number in {guessCount} guesses! " +
                "Can you beet your high score? Would you like to play again? yes/no ");
            playAgain = Console.ReadLine().ToLower();
            if (playAgain == "yes")
            {
                //check high score and print        
                if (guessCount < highScore)
                {
                    highScore = guessCount;
                    Console.WriteLine($"Your new high score is {highScore}");
                }
                else
                {
                    Console.WriteLine($"Your high score is {highScore}");
                }
                //change random number in case user decides to play again
                magicNumber = randomGenerator.Next(1, 101);
                Console.WriteLine("A new number has been generated.");
                //reset guess count
                guessCount = 0;
                // ask user for new guess
                Console.Write("What is your guess? ");
                guess = float.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Good Bye.");
            }// end if play again
        } // end play again while loop
    }// end main
}//end program