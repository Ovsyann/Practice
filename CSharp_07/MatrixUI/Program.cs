using System;
using MatrixTask;

namespace MatrixUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrixLeft = InputMatrix("Input first matrix");
            Matrix matrixRight = InputMatrix("Input second matrix");
            Matrix matrixSum = matrixLeft + matrixRight;
            ShowResult(matrixSum, "Addition result");
            Matrix matrixDifference = matrixLeft - matrixRight;
            ShowResult(matrixDifference, "Subtraction result");
            Matrix matrixMultiplication = matrixLeft * matrixRight;
            ShowResult(matrixMultiplication, "Multiplication result");

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
