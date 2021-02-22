using System;
using System.Collections.Generic;

namespace Section6Exercise5
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        /// If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
        /// otherwise, display the 3 smallest numbers in the list.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
            var input = Console.ReadLine();
            
            var numbers = new List<int>();

            foreach (var number in input.Split(","))
                numbers.Add(int.Parse(number));

            if (numbers.Count == 0 || numbers.Count < 5)
            {
                Console.WriteLine("Invalid List and ask the user to re-try.");
                return;
            }

            numbers.Sort();

            Console.WriteLine("3 smallest numbers: {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
        }
    }
}
