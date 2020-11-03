using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Password"; // the secret word / password
            string guess = "";  

            int guessIndex = 0; 
            int guessLimit = 5;
            int guessesLeft = guessLimit - guessIndex;

            bool outOfGuesses = false;
            Console.Write("Do you want to play a guessing game? : ");
            Console.ReadLine();
            Console.Write("Enter your guess : ");
            guessIndex++; 
            
            guess = Console.ReadLine();
            Console.ReadLine();

            while (guess != secretWord && outOfGuesses == false)  // when your guess is not equal to the secret Password, and you are not out of guesses.
            {
                if (guessIndex < guessLimit)
                {
                    Console.Write("Incorrect, you have " + guessesLeft + " guesses left : ");
                    Console.ReadLine();

                    guessIndex++;   // every time the guess is wrong +1 is added to the guessIndex
                }
                else
                {
                    outOfGuesses = true;
                }
                
            }

            if (outOfGuesses == true)  // when you are out of guesses
            {
                Console.Write("You are out of guesses");
            }
            else
            {
                Console.WriteLine("You guessed the seceret word!");
            }
          

        }
    }
}
