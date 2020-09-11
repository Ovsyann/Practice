using System;

namespace PointProcessorUI
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                string mode = args[0];
                if (mode.Equals("1"))
                {
                    Console.WriteLine("Welcome to files processing mode \n Please");
                }
            }
            // я должен сделать main и батники для запуска
        }
    }
}
