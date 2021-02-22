using System;
using System.Collections.Generic;

namespace Section8Exercise5
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter an English word.
        /// Count the number of vowels (a, e, o, u, i) in the word.
        /// So, if the user enters "inadequate", the program should display 6 on the console.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter an English word: ");
            var input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
                return;

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var countVowels = 0;

            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    countVowels++;
            }

            Console.WriteLine("Number of vowels: {0}", countVowels);

        }
    }
}
