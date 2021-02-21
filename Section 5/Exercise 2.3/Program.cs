using System;

namespace Section5Exercise23
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a number.
        /// Compute the factorial of the number and print it on the console.
        /// For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number = int.Parse(Console.ReadLine());
            var factorial = 1;

            for (var i = number; i >= 1; i--)
                factorial *= i;

            Console.WriteLine("{0}!= {1}", number, factorial);
        }
    }
}
