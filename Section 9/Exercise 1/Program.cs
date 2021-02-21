using System;
using System.IO;

namespace Section9Exercise1
{
    class Program
    {
        /// <summary>
        /// Write a program that reads a text file and displays the number of words.
        /// </summary>
        static void Main(string[] args)
        {
            var file = File.ReadAllText("file.txt");

            Console.WriteLine("Words in file: {0}", file.Split(" ").Length);
        }
    }
}
