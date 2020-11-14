using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MatrixTask
{
    public class Matrix : IEquatable<Matrix>
    {
        private readonly int[,] elements;

        public int RowsCount
        {
            get
            {
                return elements.GetLength(0);
            }
        }

        public int ColumnsCount
        {
            get
            {
                return elements.GetLength(1);
            }
        }

        public Matrix(int rowsCount, int columnsCount)
        {
            if (rowsCount < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(rowsCount), "must be greater than 1");
            }
            if (columnsCount < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(columnsCount), "must be greater than 1");
            }

            elements = new int[rowsCount, columnsCount];
        }

        public Matrix(int[,] newElements)
        {
            if (newElements == null)
            {
                throw new ArgumentNullException(nameof(newElements));
            }
            if (newElements.GetLength(0) < 2)
            {
                throw new InvalidOperationException("Rows count must be greater than 1");
            }
            if (newElements.GetLength(1) < 2)
            {
                throw new InvalidOperationException("Columns count must be greater than 1");
            }

            int newRowsCount = newElements.GetLength(0);
            int newColumnsCount = newElements.GetLength(1);

            elements = new int[newRowsCount, newColumnsCount];
            for(int i = 0; i < newRowsCount; i++)
            {
                for(int j = 0; j < newColumnsCount; j++)
                {
                    elements[i, j] = newElements[i, j];
                }
            }
        }

        public int this[int i, int j]
        {
            get
            {
                return elements[i, j];
            }
            set
            {
                elements[i, j] = value;
            }
        }

        public override bool Equals(object other)
        {
            return this.Equals(other as Matrix);
        }

        public bool Equals(Matrix other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (this.GetType() != other.GetType())
            {
                return false;
            }

            if (this.RowsCount != other.RowsCount || 
                this.ColumnsCount != other.ColumnsCount)
            {
                return false;
            }

            for(int i = 0; i < this.RowsCount; i++)
            {
                for(int j = 0; j < this.ColumnsCount; j++)
                {
                    if (this[i, j] != other[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = 0;
            for(int i = 0; i < this.RowsCount; i++)
            {
                for(int j = 0; j < this.ColumnsCount; j++)
                {
                    hashCode = hashCode * 33 + this[i, j] - base.GetHashCode();
                }
            }

            return hashCode;
        }

        public static bool operator ==(Matrix left, Matrix right)
        {
            if (object.ReferenceEquals(left, null))
            {
                if (object.ReferenceEquals(right, null))
                {
                    return true;
                }
            }

            return left.Equals(right);
        }

        public static bool operator !=(Matrix left, Matrix right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return string.Format("Matrix[{0},{1}]",RowsCount,ColumnsCount);
        }

        public static Matrix operator +(Matrix left,Matrix right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(nameof(left));
            }
            if (right == null)
            {
                throw new ArgumentNullException(nameof(right));
            }
            if (left.RowsCount != right.RowsCount || 
                left.ColumnsCount != right.ColumnsCount)
            {
                throw new InvalidMatrixException(left, right, "Matrices must be of the same dimensions");
            }

            Matrix newMatrix = new Matrix(left.RowsCount, left.ColumnsCount);
            for(int i = 0; i < newMatrix.RowsCount; i++)
            {
                for(int j = 0; j < newMatrix.ColumnsCount; j++)
                {
                    newMatrix[i, j] = left[i, j] + right[i, j];
                }
            }

            return newMatrix;
        }

        public static Matrix operator -(Matrix left, Matrix right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(nameof(left));
            }
            if (right == null)
            {
                throw new ArgumentNullException(nameof(right));
            }
            if (left.RowsCount != right.RowsCount ||
                left.ColumnsCount != right.ColumnsCount)
            {
                throw new InvalidMatrixException(left, right, "Matrices must be of the same dimensions");
            }

            Matrix newMatrix = new Matrix(left.RowsCount, left.ColumnsCount);
            for (int i = 0; i < newMatrix.RowsCount; i++)
            {
                for (int j = 0; j < newMatrix.ColumnsCount; j++)
                {
                    newMatrix[i, j] = left[i, j] - right[i, j];
                }
            }

            return newMatrix;
        }

        public static Matrix operator *(Matrix left, Matrix right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(nameof(left));
            }
            if (right == null)
            {
                throw new ArgumentNullException(nameof(right));
            }
            if (left.ColumnsCount != right.RowsCount)
            {
                throw new InvalidMatrixException(left, right, "Matrices must be of the same dimensions");
            }

            Matrix newMatrix = new Matrix(left.RowsCount, right.ColumnsCount);
            for(int i = 0; i < left.RowsCount; i++)
            {
                for(int j = 0; j < right.ColumnsCount; j++)
                {
                    for(int k = 0; k < left.ColumnsCount; k++)
                    {
                        newMatrix[i, j] += left[i, k] * right[k, j];
                    }
                }
            }

            return newMatrix;
        }
    }
}
