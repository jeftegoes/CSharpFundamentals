using System;

namespace Section8Exercise4
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space.
        /// Use the words to create a variable name with PascalCase.
        /// For example, if the user types: "number of students", display "NumberOfStudents".
        /// Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS",
        /// the program should still display "NumberOfStudents".
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter a few words separated by a space: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return;

            var words = input.Split(" ");

            var pascalCase = "";

            foreach (var word in words)
            {
                pascalCase += string.Concat(word.Substring(0, 1).ToUpper(), word.Substring(1).ToLower());
            }

            Console.WriteLine("Variable name with PascalCase: {0}", pascalCase);
        }
    }
}
