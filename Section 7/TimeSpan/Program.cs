using System;

namespace Section7TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan1);
            Console.WriteLine(timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: {0}", duration);

            Console.WriteLine("Minutes: {0}", timeSpan.Minutes);
            Console.WriteLine("Total Minutes: {0}", timeSpan.TotalMinutes);

            Console.WriteLine("Add Example: {0}", timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: {0}", timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            Console.WriteLine("ToString: {0}", timeSpan.ToString());

            Console.WriteLine("Parse: {0}", TimeSpan.Parse("01:02:03"));

        }
    }
}
