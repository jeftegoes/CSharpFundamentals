using System;
using System.Collections.Generic;

namespace Section8Exercise2
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen.
        /// If the user simply presses Enter, without supplying an input, exit immediately;
        /// otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();

            foreach (var number in input.Split("-"))
                numbers.Add(int.Parse(number));

            var uniques = new List<int>();
            var duplicated = new List<int>();

            numbers.Sort();

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    duplicated.Add(number);
                }
            }

            foreach (var number in duplicated)
                Console.WriteLine("Duplicated: {0}", number);
        }
    }
}
