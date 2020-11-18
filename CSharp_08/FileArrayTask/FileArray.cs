using System;
using System.IO;
using System.Text;

namespace FileArrayTask
{
    public class FileArray : IDisposable
    {
        public static FileArray Create(string path, int length)
        {
            return new FileArray(path, length);
        }

        public static FileArray Read(string path)
        {
            return new FileArray(path);
        }

        private FileArray(string path, int length)
        {
            char[] charBuffer = new char[length];

            for (int i = 0; i < length; i++)
            {
                charBuffer[i] = ' ';
            }

            OpenOrCreate(path, FileMode.Create);

            writer.Write(charBuffer);
        }

        private FileArray(string path)
        {
            OpenOrCreate(path, FileMode.Open);
        }

        private FileInfo FileInfo;
        private FileStream stream;
        private StreamWriter writer;
        private StreamReader reader;

        private void OpenOrCreate(string path, FileMode OpenOrCreate)
        {
            stream = new FileStream(path, OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            writer = new StreamWriter(stream, Encoding.Default);
            writer.AutoFlush = true;
            reader = new StreamReader(stream, Encoding.Default);
            FileInfo = new FileInfo(path);
        }

        public long Length
        {
            get
            {
                return FileInfo.Length;
            }
        }

        public char this[int index]
        {
            get
            {
                stream.Position = index;
                return (char)reader.Read();
            }
            set
            {
                stream.Position = index;
                writer.Write(value);
            }
        }

        public void Dispose()
        {
            if(stream != null)
            {
                writer.Close();
                writer = null;
                reader = null;
                stream = null;
            }
        }
    }
}
