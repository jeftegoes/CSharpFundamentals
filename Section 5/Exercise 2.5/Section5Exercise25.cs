using System;

namespace Section5Exercise25
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a series of numbers separated by comma.
        /// Find the maximum of the numbers and display it on the console.
        /// For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter a series of numbers separated by comma: ");
            var input = Console.ReadLine();

            var numbers = input.Split(",");
            var max = int.Parse(numbers[0]);

            foreach (var number in numbers)
            {
                var currentNumber = int.Parse(number);
                if (currentNumber > max)
                    max = currentNumber;
            }

            Console.WriteLine("Max is: {0}", max);
        }
    }
}
