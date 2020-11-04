using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using PolynomialTask;

namespace PolynomialTests
{
    public class PolynomialTests
    {
        [Test]
        public void TestTryCreate_Array_Created()
        {
            int[] array = { 1, default, 3, 4 };
            Polynomial polynomial = Polynomial.TryCreate(array);
            int expected = 4;
            array[3] = 5;

            Assert.AreEqual(expected, polynomial[3]);
        }

        [Test]
        public void TestTryCreate_Polynomial_Created()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            Polynomial polynomial2 = Polynomial.TryCreate(polynomial1);
            int expected = 1;

            int[] b = polynomial1.Coefficients;
            b[0] = 5;

            Assert.AreEqual(expected, polynomial1[0]);
        }

        [Test]
        [TestCase(new int[] {1,2,3,4,5},ExpectedResult = 5)]
        public int TestLength_5elements_5(int[] values)
        {
            
            Polynomial polynomial = Polynomial.TryCreate(values);


            return polynomial.Length;
        }

        [Test]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 1, 2 }, 2)]
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 6)]
        public void TestLength_elements_calculated(int[] values, int expected)
        {
            Polynomial polynomial = Polynomial.TryCreate(values);

            Assert.AreEqual(expected, polynomial.Length);
        }

        [Test]
        public void TestGetHashCode_1and2and3_Calculated()
        {
            int[] array = {-9, -1, 0, 1, 9};
            Polynomial polynomial = Polynomial.TryCreate(array);
            int expected = 0;

            int actual = polynomial.GetHashCode();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestEquals_TwoSame_True()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            Polynomial polynomial2 = Polynomial.TryCreate(polynomial1);

            Assert.IsTrue(polynomial1.Equals(polynomial2));
        }

        [Test]
        public void TestEquals_TwoDifferent_False()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            int[] array2 = { 1, 3, 5, 6 };
            Polynomial polynomial2 = Polynomial.TryCreate(array2);

            Assert.IsFalse(polynomial1.Equals(polynomial2));
        }

        [Test]
        public void TestOverridenEquality_TwoSame_True()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            int[] array2 = { 1, 2, 3, 4 };
            Polynomial polynomial2 = Polynomial.TryCreate(array2);

            Assert.IsTrue(polynomial1 == polynomial2);
        }

        [Test]
        public void TestOverridenEquality_TwoDifferent_False()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            int[] array2 = { 8, 2, 3, 4 };
            Polynomial polynomial2 = Polynomial.TryCreate(array2);

            Assert.IsFalse(polynomial1 == polynomial2);
        }

        [Test]
        public void TestOverridenNonEquality_TwoSame_False()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            int[] array2 = { 1, 2, 3, 4 };
            Polynomial polynomial2 = Polynomial.TryCreate(array2);

            Assert.IsFalse(polynomial1 != polynomial2);
        }

        [Test]
        public void TestOverridenNonEquality_TwoDifferent_True()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            int[] array2 = { 8, 2, 3, 4 };
            Polynomial polynomial2 = Polynomial.TryCreate(array2);

            Assert.IsTrue(polynomial1 != polynomial2);
        }

        

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 6, 4 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 })]
        [TestCase(new int[] { 1, 2, 3, 0 }, new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 6, 4 })]
        [TestCase(new int[] { 1, 2, 3, 5, 10 }, new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 6, 9, 10 })]
        public void TestOverridenSummary_TwoPolyninomials_Calculated(int[] valuesLeft, int[] valuesRight, int[] expected)
        {
            Polynomial polynomial1 = Polynomial.TryCreate(valuesLeft);
            Polynomial polynomial2 = Polynomial.TryCreate(valuesRight);
            Polynomial polynomialExpected = Polynomial.TryCreate(expected);

            Polynomial actual = polynomial1 + polynomial2;

            Assert.AreEqual(polynomialExpected, actual);
        }

        [Test]
        public void TestOverridenSummary_FirstIsNull_Exception()
        {
            Polynomial polynomial1 = null;
            int[] array = { 0, 1, 2 };
            Polynomial polynomial2 = Polynomial.TryCreate(array);

            void Calculate()
            {
                Polynomial actual = polynomial1 + polynomial2;
            }

            Assert.Throws<ArgumentNullException>(Calculate);
        }

        [Test]
        public void TestOverridenSummary_SecondIsNull_Exception()
        { 
            int[] array = { 0, 1, 2 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            Polynomial polynomial2 = null;

            void Calculate()
            {
                Polynomial actual = polynomial1 + polynomial2;
            }

            Assert.Throws<ArgumentNullException>(Calculate);
        }

        [Test]
        public void TestToString_023_Success()
        {
            int[] array = { 0, 2, 3 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            string expected = "0X^0 + 2X^1 + 3X^2";

            string actual = polynomial1.ToString();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(new int[] { 0, 2, 3 }, ExpectedResult ="3X^2 + 2X")]
        [TestCase(new int[] { 0, 2, 3, 4 }, "4X^3 + 3X^2 + 2X")]
        [TestCase(new int[] {-0 }, "0")]
        [TestCase(new int[] {-0, 0 }, "0")]
        [TestCase(new int[] { 0, 1 }, "X")]
        [TestCase(new int[] { 0, -1 }, " - X")]
        [TestCase(new int[] { -1, -1 }, " - X - 1")]
        [TestCase(new int[] { -0, 1, -0 }, "X")]
        [TestCase(new int[] { 0, -0, -0 }, "0")]
        [TestCase(new int[] { 0, -0, -0, -10 }, " - 10X^3")]
        [TestCase(new int[] { -15, 0, -0, -0 }, " - 15")]
        [TestCase(new int[] { -11, 0, -0, -12 }, " - 12X^3 - 11")]
        public !!! TestToStringSignificant_023_Success(int[] odds, string expectedRepresentation)
        {
            Polynomial polynomial1 = Polynomial.TryCreate(odds);
        

            string actual = polynomial1.ToStringSignificant();

            Assert.AreEqual(expectedRepresentation, actual);
        }
    }
}