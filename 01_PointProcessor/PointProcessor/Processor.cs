using System;
using System.IO;

namespace PointProcessor
{
    public class Processor
    {
        public static void ProcessFiles(string[] filenames)
        {
            foreach(var i in filenames)
            {
                if (File.Exists(i))
                {
                    using (StreamReader sr = new StreamReader(i))
                    {
                        while (sr.Peek() >= 0)
                        {
                            string readLine = ProcessLine(sr.ReadLine());
                            Console.WriteLine(readLine);
                        }
                    }
                }
            }
        }

        public static void ProcessConsole()
        {
            throw new NotImplementedException();
        }

        public static string ProcessLine(string line)
        {
            //throw new NotImplementedException();
            bool canParse = Parser.TryParsePoint(line, out Point point);
            if (canParse)
                line = Formatter.Format(point);
            else
                line = "What a pity! I Can't process this line!";
            return line;
        }
    }
}
