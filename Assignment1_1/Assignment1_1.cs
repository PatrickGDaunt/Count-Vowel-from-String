/*
 * Author: Patrick D
 * Date created: 24 Sep 2020
 * Description: Assignment 1, problem 1.
 */

using System;
using static System.Console;
using System.Reflection.PortableExecutable;

namespace Assignment1
{
    class Assignment1_1
    {
        public int CountVowels(string userInputString) // function passes a string and returns vowel count
        {
            int vowelCount = 0;
            
            for (int x = 0; x < userInputString.Length; x++) // Iterate through string
                {
                bool returnIsVowel = IsVowel(userInputString[x]); // Set IsVowel() return to variable
                if (returnIsVowel == true) // If IsVowel() returns true, increase vowelCount
                {
                    vowelCount++;
                }
            }                
            return vowelCount;
        }

        // function that passes characters and returns if the character is a vowel
        public bool IsVowel(char character) {
            // Select vowels, not icluding y
            if ((character == 'a') || (character == 'e') || (character == 'i') || (character == 'o') || (character == 'u')
                || (character == 'A') || (character == 'E') || (character == 'I') || (character == 'O') || (character == 'U'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Assignment1_1 p = new Assignment1_1(); // Instantiate class object
            
            string userInputString;
            WriteLine("Enter a String: "); // Request user entry
            userInputString = ReadLine();

            WriteLine("The string {0} contains {1} vowels.", userInputString, p.CountVowels(userInputString)); // Closing statement
        }
    }
}
