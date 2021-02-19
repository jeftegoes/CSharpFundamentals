using System;

namespace Section8String
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Mosh Hamedani ";
            
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());
            
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("Firstname: '{0}'", firstName);
            Console.WriteLine("LastName: '{0}'", lastName);

            var names = fullName.Split(" ");
            Console.WriteLine("Firstname: '{0}'", names[0]);
            Console.WriteLine("LastName: '{0}'", names[1]);
            Console.WriteLine(fullName.Replace("Mosh", "Moshfegh"));

            if (string.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            foreach (var word in fullName.Split(" "))
                Console.WriteLine(word);

            var str = 25;

            var age = Convert.ToByte(str);
            Console.WriteLine("Age: {0}", age);

            float price = 29.95f;
            Console.WriteLine("Price: {0}", price.ToString("C"));
            Console.WriteLine("Price: {0}", price.ToString("C0"));
        }
    }
}
