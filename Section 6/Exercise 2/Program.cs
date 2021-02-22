using System;

namespace Section6Exercise2
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter their name.
        /// Use an array to reverse the name and then store the result in a new string.
        /// Display the reversed name on the console.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Inform their name: ");
            var input = Console.ReadLine();

            var chars = new char[input.Length];

            for (var i = input.Length; i > 0; i--)
                chars[input.Length - i] = input[i -1];
                
            var reversed = new string(chars);

            Console.WriteLine("Reversed: {0}", reversed);
        }
    }
}
