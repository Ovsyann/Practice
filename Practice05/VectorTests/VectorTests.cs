using NUnit.Framework;
using System;
using VectorTask;

namespace VectorTests
{
    public class VectorTests
    {
        [Test]
        public void TestTryCreate_3and4and5_Created()
        {
            const int x = 3;
            const int y = 4;
            const int z = 5;

            Vector vector = Vector.TryCreate(x, y, z);

            Assert.AreEqual(x, vector.X);
            Assert.AreEqual(y, vector.Y);
            Assert.AreEqual(z, vector.Z);
        }

        [Test]
        public void TestTryCreate_3and4and5AreNegative_Created()
        {
            const int x = -3;
            const int y = -4;
            const int z = -5;

            Vector vector = Vector.TryCreate(x, y, z);

            Assert.AreEqual(x, vector.X);
            Assert.AreEqual(y, vector.Y);
            Assert.AreEqual(z, vector.Z);
        }

        [Test]
        public void TestTryCreate_AllZeroes_Exception()
        {
            const int x = 0;
            const int y = 0;
            const int z = 0;

            void Creation()
            {
                Vector vector = Vector.TryCreate(x, y, z);
            }

            Assert.Throws<InvalidOperationException>(Creation);
        }

        [Test]
        public void TestGetHashCode_3and4and5_Calculated()
        {
            const int x = 3;
            const int y = 4;
            const int z = 5;
            Vector vector = Vector.TryCreate(x, y, z);
            int expected = 3162117;

            int actual = vector.GetHashCode();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestEquals_TwoSameVectors_true()
        {
            const int x = 3;
            const int y = 4;
            const int z = 5;
            Vector vector1 = Vector.TryCreate(x, y, z);
            Vector vector2 = Vector.TryCreate(x, y, z);

            Assert.IsTrue(vector1.Equals(vector2));
        }

        [Test]
        public void TestEquals_TwoDifferentVectors_false()
        {
            const int x1 = 3;
            const int y1 = 4;
            const int z1 = 5;
            const int x2 = 4;
            const int y2 = 5;
            const int z2 = 6;
            Vector vector1 = Vector.TryCreate(x1, y1, z1);
            Vector vector2 = Vector.TryCreate(x2, y2, z2);

            Assert.IsFalse(vector1.Equals(vector2));
        }


        [Test]
        public void TestEquals_OneVectorIsNull_false()
        {
            const int x1 = 3;
            const int y1 = 4;
            const int z1 = 5;
            Vector vector1 = Vector.TryCreate(x1, y1, z1);
            Vector vector2 = null;

            Assert.IsFalse(vector1.Equals(vector2));
        }


        [Test]
        public void TestOverridenEquality_TwoSameVectors_true()
        {
            const int x1 = 3;
            const int y1 = 4;
            const int z1 = 5;
            Vector vector1 = Vector.TryCreate(x1, y1, z1);
            Vector vector2 = Vector.TryCreate(x1, y1, z1);

            Assert.IsTrue(vector1 == vector2);
        }

        [Test]
        public void TestOverridenEquality_TwoDifferentVectors_False()
        {
            const int x1 = 3;
            const int y1 = 4;
            const int z1 = 5;
            const int x2 = 4;
            const int y2 = 5;
            const int z2 = 6;
            Vector vector1 = Vector.TryCreate(x1, y1, z1);
            Vector vector2 = Vector.TryCreate(x2, y2, z2);

            Assert.IsFalse(vector1 == vector2);
        }

        [Test]
        public void TestOverridenEquality_OneVectorIsNull_False()
        {
            const int x1 = 3;
            const int y1 = 4;
            const int z1 = 5;
            Vector vector1 = Vector.TryCreate(x1, y1, z1);
            Vector vector2 = null;

            Assert.IsFalse(vector1 == vector2);
        }

        [Test]
        public void TestOverridenEquality_BothVectorsAreNull_True()
        {
            Vector vector1 = null;
            Vector vector2 = null;

            Assert.IsTrue(vector1 == vector2);
        }


        [Test]
        public void TestOverridenNonEquality_TwoSameVectors_False()
        {
            const int x1 = 3;
            const int y1 = 4;
            const int z1 = 5;
            Vector vector1 = Vector.TryCreate(x1, y1, z1);
            Vector vector2 = Vector.TryCreate(x1, y1, z1);

            Assert.IsFalse(vector1 != vector2);
        }

        [Test]
        public void TestOverridenNonEquality_TwoDifferentVectors_True()
        {
            const int x1 = 3;
            const int y1 = 4;
            const int z1 = 5;
            const int x2 = 4;
            const int y2 = 5;
            const int z2 = 6;
            Vector vector1 = Vector.TryCreate(x1, y1, z1);
            Vector vector2 = Vector.TryCreate(x2, y2, z2);

            Assert.IsTrue(vector1 != vector2);
        }

        [Test]
        public void TestOverridenNonEquality_OneVectorIsNull_True()
        {
            const int x1 = 3;
            const int y1 = 4;
            const int z1 = 5;
            Vector vector1 = Vector.TryCreate(x1, y1, z1);
            Vector vector2 = null;

            Assert.IsTrue(vector1 != vector2);
        }

        [Test]
        public void TestOverridenNonEquality_BothVectorsAreNull_False()
        {
            Vector vector1 = null;
            Vector vector2 = null;

            Assert.IsFalse(vector1 != vector2);
        }

        [Test]
        public void TestToString_TrueVector_Success()
        {
            const int x = 3;
            const int y = 4;
            const int z = 5;
            Vector vector = Vector.TryCreate(x, y, z);
            string expected = "(3,4,5)";

            string actual = vector.ToString();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestToString_NullVector_Exception()
        {
            Vector vector = null;

            void ToLine()
            {
                string actual = vector.ToString();
            }

            Assert.Throws<NullReferenceException>(ToLine);
        }
    }
}