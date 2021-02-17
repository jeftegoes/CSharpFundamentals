using System;
using System.IO;

namespace Section9FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.svg";

            File.Copy(@"c:\temp\myFile.svg", @"d:\temp\myFile.svg", true);

            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}
