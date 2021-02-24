using System.Collections.Generic;
using System;

namespace Guesser_Game
{
    class Program
    {
        static List<string> guesses = new List<string>();
        static string guessInput;

        static int wordCount = 10;
        static string[] words = {"spuds", "ketchup", "car", "genesis", "phone", "lamp", "mouse", "arm", "fan", "table"};
        static List<string> wordList = new List<string>(words);

        static void Main()
        {
            Console.WriteLine("welcome to Guesser Game!");
            Console.WriteLine("Guess the words, there are 10 in total)");


            while (wordCount > 0)
            {
                guessInput = Console.ReadLine();

                CheckGuess();
                IncorrectGuess();
                CorrectGuess();
                EndGame();
            } 
        }

        static void CorrectGuess()
        {
            if (wordList.Contains(guessInput) && !guesses.Contains(guessInput))
            {
                guesses.Add(guessInput);
                wordCount--;

                Console.WriteLine("You guessed a word!");
                Console.WriteLine(guessInput + " was correct!");

                Console.WriteLine(wordCount + " words to go!");
            }
        }

        static void IncorrectGuess()
        {
            if (!wordList.Contains(guessInput) && !guesses.Contains(guessInput))
            {
                guesses.Add(guessInput);

                Console.WriteLine(guessInput + " was incorrect");
                Console.WriteLine("Try again!");
            }
        }

        static void CheckGuess()
        {
            if (guesses.Contains(guessInput))
            {
                if (wordList.Contains(guessInput))
                {
                    Console.WriteLine("You already guessed " + guessInput);
                    Console.WriteLine("And it was correct");
                }

                if (!wordList.Contains(guessInput))
                {
                    Console.WriteLine("You already guessed " + guessInput);
                    Console.WriteLine("And it was incorrect");
                }
            }
        }

        static void EndGame()
        {
            if (wordCount <= 0)
            {
                Console.WriteLine("Gongratz!");
                Console.WriteLine("You guessed all the words!");
            }
        }
    }    
}
