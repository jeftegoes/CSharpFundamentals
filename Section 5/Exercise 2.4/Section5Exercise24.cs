using System;

namespace Section5Exercise24
{
    /// <summary>
    /// Write a program that picks a random number between 1 and 10.
    /// Give the user 4 chances to guess the number.
    /// If the user guesses the number, display “You won"; otherwise, display “You lost".
    /// (To make sure the program is behaving correctly,
    /// you can display the secret number on the console first.)
    /// <summary>
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumber = new Random().Next(1, 10);

            Console.WriteLine("Number generated: {0}", randomNumber);

            for (var i = 0; i < 4; i++)
            {
                Console.Write("Choose a number between 1 and 10: ");
                var numberChosed = int.Parse(Console.ReadLine());

                if (numberChosed == randomNumber)
                {
                    Console.Write("You won");
                    return;
                }
            }
            
            Console.Write("You lose");
        }
    }
}
