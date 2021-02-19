using System;

namespace Section3TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(b);

            // Dont work...
            // int j = 1;
            // byte h = j;

            // This work.
            int j = 1000;
            byte h = (byte)j;
            Console.WriteLine(h);

            var number = "1234";
            int x = int.Parse(number);
            Console.Write(x);

            try
            {
                var numberByte = "1234";
                byte by = byte.Parse(numberByte);
                Console.WriteLine(by);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string str = "true";
                bool bo = bool.Parse(str);
                Console.WriteLine(str);
            }
            catch (Exception)
            {

            }
        }
    }
}
