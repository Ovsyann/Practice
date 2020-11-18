using System;
using FileArrayTask;

namespace FileArrayUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveToFile("[01]Привет мир!");
        }

        private static void SaveToFile(string greeting)
        {
            FileArray file = null;

            try
            {
                file = FileArray.Create("file.txt", greeting.Length);
                //for (int i = 0; i < file.Length; i++)
                //{
                //    file[i] = greeting[i];
                //}
            }
            finally
            {
                file.Dispose();
            }
        }
    }
}
