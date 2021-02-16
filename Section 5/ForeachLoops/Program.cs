using System;

namespace Section5ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Smith";
            var numbers = new int[] {1, 2, 3, 4};

            for (var i = 0; name.Length > i; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
