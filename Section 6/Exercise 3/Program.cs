using System;
using System.Collections.Generic;

namespace Section6Exercise3
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter 5 numbers.
        /// If a number has been previously entered, display an error message and ask the user to re-try.
        /// Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        /// </summary>
        static void Main(string[] args)
        {
            const int maxValue = 5;

            var numbersEntered = new List<int>();

            for (var i = 0; i < maxValue; i++)
            {
                Console.Write("Inform the {0}º number of {1}: ", i + 1, maxValue);
                var input = Console.ReadLine();

                var numberEntered = int.Parse(input);

                // Could have used contains...
                if (numbersEntered.Contains(numberEntered))
                {
                    Console.WriteLine("The number {0} exists", numberEntered);
                    i--;
                    continue;
                }

                numbersEntered.Add(numberEntered);
            }

            numbersEntered.Sort();

            foreach (var number in numbersEntered)
                Console.WriteLine(number);
        }
    }
}
