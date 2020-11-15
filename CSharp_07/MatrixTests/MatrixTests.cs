using System;
using NUnit.Framework;
using MatrixTask;
using System.Collections.Generic;

namespace MatrixTests
{
    public class MatrixTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConstructor_Array_Created()
        {
            int[,] elements = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            Matrix matrix = new Matrix(elements);

            Assert.IsNotNull(matrix);
        }

        [Test]

        [TestCase(1, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 1)]
        [TestCase(2, 2)]
        public void TestConstructor_EmptyMatrix_Created(int rowsCount, int columnsCount)
        {
            Matrix matrix = new Matrix(rowsCount, columnsCount);

            Assert.IsNotNull(matrix);
        }

        [TestCase(1, 0)]
        [TestCase(0, 1)]
        public void TestConstructor_EmptyMatrix_Failed(int rowsCount, int columnsCount)
        {
            Matrix matrix = null;

            void Creation()
            {
                matrix = new Matrix(rowsCount, columnsCount);
            }

            Assert.Throws<ArgumentOutOfRangeException>(Creation);
            Assert.IsNull(matrix);
        }

        private static IEnumerable<TestCaseData> Source
        {
            get
            {
                yield return new TestCaseData(new int[,] { { 1, 2 }, { 3, 4 } },
                    new int[,] { { 1, 2 }, { 3, 4 } });
                yield return new TestCaseData(new int[,] { { 3, 6 } },
                    new int[,] { { 3, 6 } });
                yield return new TestCaseData(new int[,] { { 1, 2 }, { 3, 4 }, { 1, 2 } },
                    new int[,] { { 1, 2 }, { 3, 4 }, { 1, 2 } });
                yield return new TestCaseData(new int[,] { { 3 } },
                    new int[,] { { 3 } });
                yield return new TestCaseData(new int[,] { { 3 }, { 3 } },
                    new int[,] { { 3 }, { 3 } });
            }
        }

        [Test]
        [TestCaseSource(nameof(Source))]
        public void TestEquals(int[,] left, int[,] right)
        {
            Matrix matrixLeft = new Matrix(left);
            Matrix matrixRight = new Matrix(right);
            bool expected = true;

            bool actual = matrixLeft.Equals(matrixRight);

            Assert.AreEqual(expected, actual);
        }

        private static object[] GetArrays = new object[]
        {
            new int[,]{ { 1 } },
            new int[,]{ { 1 }, { 1 } },
            new int[,]{ { 1, 2 }, { 3, 4 } },
            new int[,]{ { 1, 2, 3 }, { 4, 5, 6 } },
            new int[,]{ { 1, 2 }, { 4, 5 }, { 6, 7 } }
        };

        [Test]
        public void TestGetHashCode([ValueSource(nameof(GetArrays))] int[,] a,
            [ValueSource(nameof(GetArrays))] int[,] b)
        {
            Matrix matrixA = new Matrix(a);
            Matrix matrixB = new Matrix(b);
            bool expected = matrixA.Equals(matrixB);

            bool actual = matrixA.GetHashCode() == matrixB.GetHashCode();

            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<TestCaseData> AdditionSource
        {
            get
            {
                yield return new TestCaseData(new int[,] { { 1, 2 }, { 3, 4 } },
                    new int[,] { { 1, 2 }, { 3, 4 } }, new int[,] { { 2, 4 }, { 6, 8 } });
                yield return new TestCaseData(new int[,] { { 3, 6 } },
                    new int[,] { { 3, 6 } }, new int[,] { { 6, 12 } });
                yield return new TestCaseData(new int[,] { { 1, 2 }, { 3, 4 }, { 1, 2 } },
                    new int[,] { { 1, 2 }, { 3, 4 }, { 1, 2 } }, new int[,] { { 2, 4 }, { 6, 8 }, { 2, 4 } });
                yield return new TestCaseData(new int[,] { { 3 } },
                    new int[,] { { 3 } }, new int[,] { { 6 } });
                yield return new TestCaseData(new int[,] { { 3 }, { 3 } },
                    new int[,] { { 3 }, { 3 } }, new int[,] { { 6 }, { 6 } });
            }
        }

        [Test]
        [TestCaseSource(nameof(AdditionSource))]
        public void TestAddition(int[,] A, int[,] B, int[,] C)
        {
            Matrix matrixA = new Matrix(A);
            Matrix matrixB = new Matrix(B);
            Matrix matrixExpected = new Matrix(C);

            Matrix matrixActual = matrixA + matrixB;

            Assert.AreEqual(matrixExpected, matrixActual);
        }

        private static IEnumerable<TestCaseData> SubstractionSource
        {
            get
            {
                yield return new TestCaseData(new int[,] { { 1, 2 }, { 3, 4 } },
                    new int[,] { { 1, 2 }, { 3, 4 } }, new int[,] { { 0, 0 }, { 0, 0 } });
                yield return new TestCaseData(new int[,] { { 3, 6 } },
                    new int[,] { { 3, 6 } }, new int[,] { { 0, 0 } });
                yield return new TestCaseData(new int[,] { { 5, 2 }, { 3, 8 }, { 2, 2 } },
                    new int[,] { { 1, 2 }, { 3, 4 }, { 1, 3 } }, new int[,] { { 4, 0 }, { 0, 4 }, { 1, -1 } });
                yield return new TestCaseData(new int[,] { { 3 } },
                    new int[,] { { 5 } }, new int[,] { { -2 } });
                yield return new TestCaseData(new int[,] { { 3 }, { 4 } },
                    new int[,] { { 3 }, { 3 } }, new int[,] { { 0 }, { 1 } });
            }
        }

        [Test]
        [TestCaseSource(nameof(SubstractionSource))]
        public void TestSubstraction(int[,] A, int[,] B, int[,] C)
        {
            Matrix matrixA = new Matrix(A);
            Matrix matrixB = new Matrix(B);
            Matrix matrixExpected = new Matrix(C);

            Matrix matrixActual = matrixA - matrixB;

            Assert.AreEqual(matrixExpected, matrixActual);
        }

        private static IEnumerable<TestCaseData> MultiplicationSource
        {
            get
            {
                yield return new TestCaseData(new int[,] { { 1, 2 }, { 3, 4 } },
                    new int[,] { { 1, 2 }, { 3, 4 } }, new int[,] { { 7, 10 }, { 15, 22 } });
                yield return new TestCaseData(new int[,] { { 3, 6 } },
                    new int[,] { { 3, 6 }, { 7, 10 } }, new int[,] { { 51, 78 } });
                yield return new TestCaseData(new int[,] { { 5, 2, 7 }, { 3, 8, 2 }, { 2, 2, 5 } },
                    new int[,] { { 1, 2 }, { 3, 4 }, { 1, 3 } }, new int[,] { { 18, 39 }, { 29, 44 }, { 13, 27 } });
                yield return new TestCaseData(new int[,] { { 3 } },
                    new int[,] { { 5 } }, new int[,] { { 15 } });
                yield return new TestCaseData(new int[,] { { 3, 1 }, { 4, 2 } },
                    new int[,] { { 3 }, { 3 } }, new int[,] { { 12 }, { 18 } });
            }
        }

        [Test]
        [TestCaseSource(nameof(MultiplicationSource))]
        public void TestMultiplication(int[,] A, int[,] B, int[,] C)
        {
            Matrix matrixA = new Matrix(A);
            Matrix matrixB = new Matrix(B);
            Matrix matrixExpected = new Matrix(C);

            Matrix matrixActual = matrixA * matrixB;

            Assert.AreEqual(matrixExpected, matrixActual);
        }

        [Test]
        public void TestMultiplication_WrongDimension_Exception()
        {
            int[,] A = new int[,] { { 1 }, { 2 } };
            int[,] B = new int[,] { { 1 }, { 2 } };
            Matrix matrixA = new Matrix(A);
            Matrix matrixB = new Matrix(B);

            void Calculation()
            {
                Matrix matrixActual = matrixA * matrixB;
            }

            Assert.Throws<InvalidMatrixException>(Calculation);
        }
    }
}