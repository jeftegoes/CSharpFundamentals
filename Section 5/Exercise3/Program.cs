using System;

namespace Section5Exercise3
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image.
        /// Then tell if the image is landscape or portrait.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Inform the height:");
            var height = int.Parse(Console.ReadLine());

            Console.WriteLine("Inform the width:");
            var width = int.Parse(Console.ReadLine());

            var orientation = height > width ? Orientation.Portrait : Orientation.Landscape;

            Console.WriteLine("Image orientation is: {0}", orientation);
        }
    }
}
