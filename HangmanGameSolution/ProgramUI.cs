using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanUI
{
    public class ProgramUI
    {
        public void Game()
        {
            Console.WriteLine("Welcome to Hangman! \n" +
                "Your mystery word is a type of fruit.");

            //Get all the characters of a random word
            bool keepPlaying = true;
            int livesLeft = 6;
            string[] words = { "apple", "orange", "banana" };
            Random randomWord = new Random();
            var random = randomWord.Next(0, 2);
            char[] letters = words[random].ToCharArray();
            string hiddenWord = String.Concat(letters);

            //Print the number of characters in the random word as '-'
            int wordLength = letters.Length;
            char[] printArray = new char[wordLength];
            int counter = -1;
            foreach (char letter in printArray)
            {
                counter++;
                printArray[counter] = '-';
                Console.WriteLine(printArray[counter]);
            }

            //Get the player's guess
            while (keepPlaying)
            {
                Console.WriteLine("Guess a letter:");
                string playerGuess = Console.ReadLine();
                playerGuess = playerGuess.ToLower();
                char playerChar = Convert.ToChar(playerGuess);

                //Check if player's guess matches the array of characters
                //If correct, display character
                if (letters.Contains(playerChar))
                {
                    foreach (char letter in printArray)
                    {
                        if (letter == playerChar)
                        {
                            printArray[counter] = playerChar;
                        }
                    }
                    //for (int playerLetter = 0; playerLetter < letters.Length; playerLetter++)
                    //{
                    //    if (playerChar == letters[playerLetter])
                    //        letters[playerLetter] = playerChar;
                    //}
                    //Console.WriteLine(letters);
                }

                //If incorrect, take away a life
                else
                {
                    livesLeft--;
                }

                //Display lives left
                if (livesLeft == 6)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "|         ");
                }
                else if (livesLeft == 5)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "5 LIVES LEFT");
                }
                else if (livesLeft == 4)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|        |\n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "4 LIVES LEFT");
                }
                else if (livesLeft == 3)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|       /|\n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "3 LIVES LEFT");
                }
                else if (livesLeft == 2)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|       /|\\ \n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "2 LIVES LEFT");
                }
                else if (livesLeft == 1)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|       /|\\ \n" +
                                       "|       /  \n" +
                                       "|         \n" +
                                       "1 LIFE LEFT");
                }
                else if (livesLeft == 0)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|       /|\\ \n" +
                                       "|       / \\ \n" +
                                       "|         \n" +
                                       "YOU'VE BEEN HANGED!");
                    Console.ReadKey();
                    keepPlaying = false;
                }

                //If player guesses all letters show victory
                string playerWord = String.Concat(playerChar);
                if (hiddenWord == playerWord)
                {
                    Console.WriteLine("Good job! You correctly guessed the word");
                }
            }
        }
    }
}
