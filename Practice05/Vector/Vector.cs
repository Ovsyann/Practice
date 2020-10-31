using System;

namespace VectorTask
{
    public class Vector : IEquatable<Vector>
    {
        private Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector TryCreate(int x, int y, int z)
        {
            if (x == 0 && y == 0 && z == 0)
            {
                throw new InvalidOperationException(string.Format("Vector with parameters {0}, {1}, {2} does not exists", x, y, z));
            }

            return new Vector(x, y, z);
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public static Vector operator +(Vector left, Vector right)
        {
            if(left==null)
            {
                throw new ArgumentNullException(string.Format("Vector {0} is null", left));
            }
            if (right == null)
            {
                throw new ArgumentNullException(string.Format("Vector {0} is null", right));
            }

            int x = left.X + right.X;
            int y = left.Y + right.Y;
            int z = left.Z + right.Z;

            return new Vector(x, y, z);
        }

        public static Vector operator -(Vector left, Vector right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(string.Format("Vector {0} is null", left));
            }
            if (right == null)
            {
                throw new ArgumentNullException(string.Format("Vector {0} is null", right));
            }

            int x = left.X - right.X;
            int y = left.Y - right.Y;
            int z = left.Z - right.Z;

            return new Vector(x, y, z);
        }

        public static Vector operator *(Vector left, Vector right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(string.Format("Vector {0} is null", left));
            }
            if (right == null)
            {
                throw new ArgumentNullException(string.Format("Vector {0} is null", right));
            }

            int x = left.X * right.X;
            int y = left.Y * right.Y;
            int z = left.Z * right.Z;

            return new Vector(x, y, z);
        }

        public static Vector CrossProduct(Vector left, Vector right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(string.Format("Vector {0} is null", left));
            }
            if (right == null)
            {
                throw new ArgumentNullException(string.Format("Vector {0} is null", right));
            }

            int x = left.Y * right.Z - left.Z * right.Y;
            int y = left.Z * right.X - left.X * right.Z;
            int z = left.X * right.Y - left.Y * right.X;

            return new Vector(x, y, z);
        }

        public override bool Equals(object other)
        {
            return this.Equals(other as Vector);
        }

        public bool Equals(Vector vector)
        {
            if (Object.ReferenceEquals(vector, null))
            {
                return false;
            }

            if (Object.ReferenceEquals(this, vector))
            {
                return true;
            }

            if (this.GetType() != vector.GetType())
            {
                return false;
            }

            return (this.X == vector.X) && (this.Y == vector.Y) && (this.Z == vector.Z);
        }

        public override int GetHashCode()
        {
            return (X * 0x100000) + (Y * 0x1000) + Z;
        }

        public static bool operator ==(Vector left,Vector right)
        {
            if (Object.ReferenceEquals(left, null))
            {
                if (Object.ReferenceEquals(right, null))
                {
                    return true;
                }
            }

            return left.Equals(right);
        }

        public static bool operator !=(Vector left, Vector right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return string.Format("({0},{1},{2})",X,Y,Z);
        }
    }
}
