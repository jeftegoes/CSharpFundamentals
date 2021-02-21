using System;

namespace Section5Exercise11
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a number.
        /// The number should be between 1 to 10.
        /// If the user enters a valid number, display "Valid" on the console.
        // Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 to 10:");

            var x = int.Parse(Console.ReadLine());

            Console.WriteLine("Number choosed: {0}", x);

            if (x >= 1 && x <= 10)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.Write("Invalid.");
            }
        }
    }
}
