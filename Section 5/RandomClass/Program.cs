using System;

namespace Section5RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            const int passwordLength = 10;

            var random = new Random();

            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);
            
            Console.Write(password);
        }
    }
}
