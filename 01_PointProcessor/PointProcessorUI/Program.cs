using PointProcessor;
using System;

namespace PointProcessorUI
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                Console.WriteLine("Welcome to files processing mode");
                Processor.ProcessFiles(args);    
            }
            else
            {
                Console.WriteLine("Welcome to console processing mode");
                Processor.ProcessConsole();
            }
            
        }
    }
}
