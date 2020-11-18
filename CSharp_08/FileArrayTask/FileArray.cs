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

            for(int i = 0; i < length; i++)
            {
                charBuffer[i] = ' ';
            }
            
            stream = File.Open(path,FileMode.Create,FileAccess.ReadWrite);
            writer = new StreamWriter(stream, Encoding.GetEncoding(1251));
            reader = new StreamReader(stream, Encoding.GetEncoding(1251));
            fileInfo = new FileInfo(path);

            writer.Write(charBuffer, 0, length - 1);
        }

        private FileArray(string path)
        {
            stream = new FileStream(path, FileMode.Open);
            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);
            fileInfo = new FileInfo(path);
        }

        private FileInfo fileInfo;
        private FileStream stream;
        private StreamWriter writer;
        private StreamReader reader;

        public long Length
        {
            get
            {
                return fileInfo.Length;
            }
        }

        public char this[int index]
        {
            get
            {
                char[] charBuffer = new char[Length];
                reader.Read(charBuffer, index, 1);
                return charBuffer[index];
            }
            set
            {
                char[] charBuffer = new char[Length];
                charBuffer[index] = value;
                writer.Write(charBuffer, index, 1);
            }
        }

        public void Dispose()
        {
            if (stream != null)
            {
                stream.Flush();
                stream.Close();
                stream = null;
            }
            if(reader != null)
            {
                reader.Close();
                reader = null;
            }
            if(writer != null)
            {
                writer = null;
            }
        }
    }
}
