using System;

namespace Section6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            Console.WriteLine("Length: {0}", numbers.Length );

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: {0}", index);

            Array.Clear(numbers, 0, 2);

            foreach (var number in numbers)
                Console.WriteLine(number);

            var another = new int[3];
            Array.Copy(numbers, another, 3);
            
            Console.WriteLine("Effect of Copy()");
            foreach (var number in another)
                Console.WriteLine(number);

            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach (var number in numbers)
                Console.WriteLine(number);

            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach (var number in numbers)
                Console.WriteLine(number);

            
        }
    }
}
