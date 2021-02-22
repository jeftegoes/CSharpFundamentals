using System;

namespace Section8Exercise3
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok";
        /// otherwise, display "Invalid Time". If the user doesn't provide any values,
        /// consider it as invalid time.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter a time value in the 24-hour time format: ");
            var input = Console.ReadLine();

            try
            {
                TimeSpan.Parse(input);
            }
            catch
            {
                Console.Write("Invalid time.");
                return;
            }

            Console.Write("Ok.");
        }
    }
}
