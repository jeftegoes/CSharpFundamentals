using System;

namespace Section5WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;

            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);

                i++;
            }

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: {0}", input);
                    continue;
                }

                break;
            }
        }
    }
}
