using System;
using System.IO;

namespace Section9Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText("file.txt").Split(" ");
            
            var maxLengthWord = words[0].Length;

            var longestWord = "";

            foreach (var word in words)
            {
                if (word.Length > maxLengthWord)
                    longestWord = word;
            }

            Console.WriteLine("Longest word in the file: {0}", longestWord);
        }
    }
}
