using System;

namespace Section5Exercise21
{
    class Program
    {
        /// <summary>
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        /// Display the count on the console.
        /// </summary>
        static void Main(string[] args)
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    count += 1;
                }
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }
    }
}
