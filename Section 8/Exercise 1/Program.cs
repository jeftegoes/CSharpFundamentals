using System;
using System.Collections.Generic;

namespace Section8Exercise1
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen.
        /// Work out if the numbers are consecutive.
        /// For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive";
        /// otherwise, display "Not Consecutive".
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine().Split("-");

            var numbers = new List<int>();
            foreach (var number in input)
                numbers.Add(int.Parse(number));

            numbers.Sort();
            
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != (numbers[i-1] + 1))
                {
                    Console.WriteLine("Not Consecutive");
                    return;
                }
            }

            Console.WriteLine("Consecutive");
        }
    }
}
