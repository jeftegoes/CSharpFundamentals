using System;
using System.Collections.Generic;

namespace Section6Exercise1
{
    class Program
    {
        /// <summary>
        /// When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        /// If no one likes your post, it doesn't display anything.
        /// If only one person likes your post, it displays: [Friend's Name] likes your post.
        /// If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        /// If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
        /// Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
        /// Depending on the number of names provided, display a message based on the above pattern.
        /// </summary>

        static void Main(string[] args)
        {
            var friends = new List<String>();

            while (true)
            {
                Console.WriteLine("Type a name (or hit ENTER to quit): ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                friends.Add(input);
            };

            var count = friends.Count;

            if (count == 1)
                Console.WriteLine("{0} likes your post.", friends[0]);
            else if (count == 2)
                Console.WriteLine("{0} and {1} like your post.", friends[0], friends[1]);
            else
                Console.WriteLine("{0} and {1} and {2} others like your post.", friends[0], friends[1], count - 2);
        }
    }
}
