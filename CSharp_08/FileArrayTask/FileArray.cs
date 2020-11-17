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
            charBuffer = new char[length];

            for(int i = 0; i < length; i++)
            {
                charBuffer[i] = ' ';
            }
            
            stream = new FileStream(path, FileMode.Create);
            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);

            writer.WriteLine(charBuffer);
        }

        private FileArray(string path)
        {
            stream = new FileStream(path, FileMode.Open);
            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);

            int symbolCount = 0;
            while (reader.Peek() > -1)
            {
                symbolCount++;
            }

            charBuffer = new char[symbolCount];
        }

        char[] charBuffer;
        private FileStream stream;
        private TextWriter writer;
        private TextReader reader;

        public int Length
        {
            get
            {
                return charBuffer.Length;
            }
        }

        public char this[int index]
        {
            get
            {
                reader.Read(charBuffer, index, 1);
                return charBuffer[index];
            }
            set
            {
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
