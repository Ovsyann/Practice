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
                            string processedLine = ProcessLine(sr.ReadLine());
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
            throw new NotImplementedException();

            //Код для парсера, а не для процессера

            //string[] pointsInLine = line.Split(',');
            //decimal pointX = decimal.Parse(pointsInLine[0]);
            //decimal pointY = decimal.Parse(pointsInLine[1]);

            //Point point = new Point(pointX, pointY);
            //return line;
        }
    }
}
