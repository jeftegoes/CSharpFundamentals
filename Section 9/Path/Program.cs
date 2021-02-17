using System;
using System.IO;

namespace Section9Path
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\CSharp\CSharp Fundamentals\Section 9\FileAndFileInfo\Program.cs";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: {0}", Path.GetExtension(path));
            Console.WriteLine("File Name: {0}", Path.GetFileName(path));
            Console.WriteLine("File Name Without Extension: {0}", Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: {0}", Path.GetDirectoryName(path));

        }
    }
}
