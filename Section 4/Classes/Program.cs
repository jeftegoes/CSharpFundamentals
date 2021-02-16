using System;
using Section4Classes.Math;

namespace Section4Classes
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var john = new Person() { FirstName = "John", LastName = "Smith" };
            john.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine("result calculator: {0}", result);
        }
    }
}
