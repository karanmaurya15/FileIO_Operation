namespace FileIO_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to File I/O Operation\n");
            FileIO obj = new FileIO();
            obj.FileExit();
            obj.ReadAllLines();
            obj.ReadAllText();
        }
    }
}