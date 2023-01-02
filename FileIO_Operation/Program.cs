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
            obj.CopyPath();
            obj.DeletePath();

            StreamClass streamClass = new StreamClass();
            Console.WriteLine("\nStream Read and Write Operation");
            streamClass.StreamWriter();
            streamClass.StreamReader();
        }
    }
}