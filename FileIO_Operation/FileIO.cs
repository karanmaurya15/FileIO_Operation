using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Operation
{
    internal class FileIO
    {
        public void FileExit()
        {
            string Path = @"C:\BridgeLabz\FileIO_Operation\FileIO_Operation\TextFile.txt";
            if (File.Exists(Path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
        }
        public void ReadAllLines()
        {
            string Path = @"C:\BridgeLabz\FileIO_Operation\FileIO_Operation\TextFile.txt";
            string[] lines;
            lines = File.ReadAllLines(Path);
            Console.WriteLine("\nFile Contain :->");
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public void ReadAllText()
        {
            string Path = @"C:\BridgeLabz\FileIO_Operation\FileIO_Operation\TextFile.txt";
            string text;
            text = File.ReadAllText(Path);
            Console.WriteLine("\nFile Text :-");
            Console.WriteLine(text);
        }
    }
}
