using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Operation
{
    internal class StreamClass
    {
        public void StreamWriter()
        {
            string Path = @"C:\BridgeLabz\FileIO_Operation\FileIO_Operation\TextFile1.txt";
            using (StreamWriter sw = File.AppendText(Path))
            {
                sw.WriteLine("Hello World, .net is awsome");
                sw.Close();
                Console.WriteLine(File.ReadAllText(Path));
            }
        }

        public void StreamReader()
        {
            string Path = @"C:\BridgeLabz\FileIO_Operation\FileIO_Operation\TextFile1.txt";
            using (StreamReader sr = File.OpenText(Path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        } 
    }
}
