using System;
using System.IO;
using System.Text;

namespace FileArrayTask
{
    public class FileArray : IDisposable
    {
        private FileArray(string path, int length)
        {
            this.length = length;

            for(int i = 0; i < length; i++)
            {
                fileData += " ";
            }

            stream = new FileStream(path, FileMode.Create);
            byteBuffer = Encoding.ASCII.GetBytes(fileData);
            stream.Write(byteBuffer, 0, byteBuffer.Length);

            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);
        }

        byte[] byteBuffer;
        char[] charBuffer;
        private Stream stream;
        private TextWriter writer;
        private TextReader reader;
        private string fileData;
        private int length;

        public FileArray this[int index]
        {
            get
            {
                reader.Read(charBuffer, index, 1);
                byteBuffer[index] = byte.Parse(charBuffer[index].ToString());
                return BitConverter.ToString(byteBuffer).Replace("-", "");
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
