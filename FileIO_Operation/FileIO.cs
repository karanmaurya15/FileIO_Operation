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
    }
}
