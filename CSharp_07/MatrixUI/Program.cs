using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using MatrixTask;

namespace MatrixUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrixLeft = InputMatrix("Input first matrix");
            Matrix matrixRight = InputMatrix("Input second matrix");
            AddAndShow(matrixLeft, matrixRight);
            SubtractAndShow(matrixLeft, matrixRight);
            MultiplyAndShow(matrixLeft, matrixRight);

        }

        private static void MultiplyAndShow(Matrix matrixLeft, Matrix matrixRight)
        {
            try
            {
                Matrix matrixMultiplication = matrixLeft * matrixRight;
                ShowResult(matrixMultiplication, "Multiplication result");
            }
            catch (InvalidMatrixException ex)
            {
                ProcessException(ex);
                return;
            }
        }

        private static void SubtractAndShow(Matrix matrixLeft, Matrix matrixRight)
        {
            try
            {
                Matrix matrixDifference = matrixLeft - matrixRight;
                ShowResult(matrixDifference, "Subtraction result");
            }
            catch (InvalidMatrixException ex)
            {
                ProcessException(ex);
                return;
            }
        }

        private static void AddAndShow(Matrix matrixLeft, Matrix matrixRight)
        {
            try
            {
                Matrix matrixSum = matrixLeft + matrixRight;
                ShowResult(matrixSum, "Addition result");
            }
            catch (InvalidMatrixException ex)
            {
                ProcessException(ex);
                return;
            }
        }

        private static void ProcessException(InvalidMatrixException ex)
        {
            using (FileStream fileStream = new FileStream("MatrixInfo.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.File));

                formatter.Serialize(fileStream, ex);

                fileStream.Position = 0;
                InvalidMatrixException invalidMatrix =
                    (InvalidMatrixException)formatter.Deserialize(fileStream);

                Console.WriteLine(ex.Message);
                Console.WriteLine("Left value: Matrix[{0},{1}]",
                    invalidMatrix.LeftRowsCount, invalidMatrix.LeftColumnsCount);
                Console.WriteLine("Right value: Matrix[{0},{1}]",
                    invalidMatrix.RightRowsCount, invalidMatrix.RightColumnsCount);

                throw invalidMatrix;
            }
        }

        private static void ShowResult(Matrix matrix, string message)
        {
            Console.WriteLine(message);
            for(int i = 0; i < matrix.RowsCount; i++)
            {
                for(int j = 0; j < matrix.ColumnsCount; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        private static Matrix InputMatrix(string inputMessage)
        {
            Console.WriteLine(inputMessage);
            string failMessage = "Input number at least 2";
            int minValue = 2;

            int rowsCount = InputInteger("Input matrix rows count", failMessage, minValue);
            int columnsCount = InputInteger("Input matrix columns count", failMessage, minValue);
            int[,] elements = InputElements(rowsCount, columnsCount);

            return new Matrix(elements); 
        }

        private static int[,] InputElements(int rowsCount, int columnsCount)
        {
            Console.WriteLine("Alternately input the elements of the matrix");

            int[,] elements = new int[rowsCount, columnsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for(int j = 0; j < columnsCount; j++)
                {
                    string inputMessage = string.Format("element[{0},{1}]", i, j);
                    elements[i, j] = InputInteger(inputMessage, "input an integral number", null);
                }
            }

            return elements;
        }

        private static int InputInteger(string inputMessage, string failMessage, int? min)
        {
            Console.WriteLine(inputMessage);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || (min.HasValue && number < min))
            {
                Console.WriteLine(failMessage);
            }

            return number;
        }
    }
}
