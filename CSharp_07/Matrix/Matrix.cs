using System;
using System.Diagnostics.CodeAnalysis;

namespace Matrix
{
    public class Matrix : IEquatable<Matrix>
    {
        private readonly int[,] elements;

        public Matrix(int rowsCount, int columnsCount)
        {
            elements = new int[rowsCount, columnsCount];
        }

        public Matrix(int[,] matrix)
        {
            //!!!
        }

        public override bool Equals(object other)
        {
            return this.Equals(other as Matrix);
        }

        public bool Equals(Matrix other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (this.GetType() != other.GetType())
            {
                return false;
            }

            //реализация сравнения
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
