using System;
using FileArrayTask;

namespace FileArrayUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveToFile("[01] Hello World!","file.txt");
            Show("file.txt");
            RewriteSymbol(2,'2', "file.txt");
            Show("file.txt");
        }

        private static void RewriteSymbol(int index, char newSymbol, string path)
        {
            using (FileArray file = FileArray.Read(path))
            {
                file[index] = newSymbol;
            }
        }

        private static void Show(string path)
        {
            FileArray file = null;
            using(file = FileArray.Read(path))
            {
                for(int i = 0; i < file.Length; i++)
                {
                    Console.Write(file[i]);
                }

                Console.WriteLine();
            }
        }

        private static void SaveToFile(string line, string path)
        {
            FileArray file = null;

            try
            {
                file = FileArray.Create(path, line.Length);
                for (int i = 0; i < file.Length; i++)
                {
                    file[i] = line[i];
                }
            }
            finally
            {
                file.Dispose();
            }
        }
    }
}
