using System;

namespace Section5Exercise12
{
    class Program
    {
        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first valid number (x):");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second valid number (y):");
            var y = int.Parse(Console.ReadLine());

            var max = (x > y) ? x : y;

            Console.WriteLine("greater number: {0}", max);
        }
    }
}
