using System;

namespace Section3Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b);

            var x = 1;
            var y = 2;
            var z = 3;

            Console.WriteLine(x + y * z);
            Console.WriteLine((x + y) * z);
            Console.WriteLine(x > y);
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(!(x != y));
            Console.WriteLine(z > y && z > y);
            Console.WriteLine(z > y && z == y);
            Console.WriteLine(z > y || z == y);
            Console.WriteLine(!(z > y || z == y));
        }
    }
}
