using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cop2360_Assign3_webberks
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates array 
            string[] hangmanWords = new string[10];
            string wordFile = "words.txt";
            int count = 0;
            int position = 0;
            int numTry = 0;

            do
            {
                numTry = 0;
                Console.Clear();
                InsertHangmanPic(numTry);

                // opens file 
                StreamReader inputFile = new StreamReader(wordFile);

                // populates array from file
                for (count = 0; count < 10; count++)
                {
                    hangmanWords[count] = inputFile.ReadLine();
                }
                inputFile.Close();

                // random number is created
                Random rnd1 = new Random();
                string guessword = hangmanWords[rnd1.Next(10)];
                string blanks = "";

                // inserts a "*" for the length of the random word selected
                for (count = 0; count < guessword.Length; count++)
                {
                    blanks += "*";
                }
                Console.WriteLine();
                //Console.WriteLine(guessword);
                Console.WriteLine("     " + blanks);

                // loop While guesses is less than 6 and compares blanks to guessword
                while ((numTry < 6) && (blanks.CompareTo(guessword) != 0))
                {
                    Console.WriteLine();
                    Console.Write("What letter would like to guess? ");

                    char character = char.Parse(Console.ReadLine());

                    position = guessword.IndexOf(character);

                    // good guess
                    if (position != -1)
                    {
                        // replace each character in blanks array with found letter
                        while ((position != -1) && (guessword.IndexOf(character, position) >= 0))
                        {
                            blanks = blanks.Remove(position, 1);
                            blanks = blanks.Insert(position, character.ToString());

                            position = guessword.IndexOf(character, position + 1);
                        }

                        // display good message to user
                        Console.Clear();
                        InsertHangmanPic(numTry);

                    }
                    // bad guess
                    else 
                    {
                        // display bad message to user
                        Console.Clear();
                        numTry = numTry + 1; // increment number of guesses
                        InsertHangmanPic(numTry, character);
                    }

                    // display number of blanks
                    Console.WriteLine();
                    Console.WriteLine("     " + blanks);


                } // end inner while loop

                // display losing message
                if (numTry > 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("The word was " + guessword);
                }
                else // display congrats message
                {
                    Console.WriteLine();
                    Console.WriteLine("You WIN!");
                }

                Console.WriteLine();
                Console.Write("Would you like to play again? ");
            }
            while (Console.ReadLine() == "y");

        }
        // overloaded function: passes numTry, if correct.
        //                      passes numTry and character if not.
        public static void InsertHangmanPic(int numTry)
        {
            switch (numTry)
            {
                case 1:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("     ______");
                    Console.WriteLine("      |    |");
                    Console.WriteLine("      O    |");
                    Console.WriteLine("           |");
                    Console.WriteLine("           |");
                    Console.WriteLine("     ______|");
                    break;
                case 2:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("       O   |");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("           |");
                    Console.WriteLine("     ______|");
                    break;
                case 3:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("       O   |");
                    Console.WriteLine("      /|   |");
                    Console.WriteLine("           |");
                    Console.WriteLine("     ______|");
                    break;
                case 4:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("       O   |");
                    Console.WriteLine("      /|\\  |");
                    Console.WriteLine("           |");
                    Console.WriteLine("     ______|");
                    break;
                case 5:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("       O   |");
                    Console.WriteLine("      /|\\  |");
                    Console.WriteLine("      /    |");
                    Console.WriteLine("     ______|");
                    break;
                case 6:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("       O   |");
                    Console.WriteLine("      /|\\  |");
                    Console.WriteLine("      / \\ |");
                    Console.WriteLine("     ______|");
                    break;
                default:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("           |");
                    Console.WriteLine("           |");
                    Console.WriteLine("           |");
                    Console.WriteLine("     ______|");
                    break;
            }
        }

        public static void InsertHangmanPic(int numTry, char character)
        {
            switch (numTry)
            {
                case 1:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("      |    |");
                    Console.WriteLine("      O    |");
                    Console.WriteLine("           |");
                    Console.WriteLine("           |");
                    Console.WriteLine("     ______|");
                    Console.WriteLine("Letter " + character + " not found, try again.");
                    Console.WriteLine("Only 5 incorrect guesses left");
                    break;
                case 2:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("      |    |");
                    Console.WriteLine("      O    |");
                    Console.WriteLine("      |    |");
                    Console.WriteLine("           |");
                    Console.WriteLine("     ______|");
                    Console.WriteLine("Letter " + character + " not found, try again.");
                    Console.WriteLine("Only 4 incorrect guesses left");
                    break;
                case 3:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("       O   |");
                    Console.WriteLine("      /|   |");
                    Console.WriteLine("           |");
                    Console.WriteLine("     ______|");
                    Console.WriteLine("Letter " + character + " not found, try again.");
                    Console.WriteLine("Only 3 incorrect guesses left");
                    break;
                case 4:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("       O   |");
                    Console.WriteLine("      /|\\  |");
                    Console.WriteLine("           |");
                    Console.WriteLine("     ______|");
                    Console.WriteLine("Letter " + character + " not found, try again.");
                    Console.WriteLine("Only 2 incorrect guesses left");
                    break;
                case 5:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("       O   |");
                    Console.WriteLine("      /|\\  |");
                    Console.WriteLine("      /    |");
                    Console.WriteLine("     ______|");
                    Console.WriteLine("Letter " + character + " not found, try again.");
                    Console.WriteLine("Only 1 incorrect guesses left");
                    break;
                case 6:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("       O   |");
                    Console.WriteLine("      /|\\  |");
                    Console.WriteLine("      / \\  |");
                    Console.WriteLine("     ______|");
                    Console.WriteLine("GAME OVER, YOU'VE BEEN HANGED");
                    break;
                default:
                    Console.WriteLine("THE GAME OF HANGMAN");
                    Console.WriteLine("      ______");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("           |");
                    Console.WriteLine("           |");
                    Console.WriteLine("           |");
                    Console.WriteLine("     ______|");
                    break;
            }
        }
    }
}
