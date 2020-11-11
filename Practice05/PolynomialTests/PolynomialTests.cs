using System;
using System.Reflection;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using PolynomialTask;


namespace PolynomialTests
{
    public class PolynomialTests
    {
        //[Test]
        //public void TestConstructor_Incaps_Success()
        //{
        //    int[] expected = { -4, 6, 9 };
        //    Polynomial polynomial = new Polynomial(expected);


        //    Polynomial actual = new Polynomial(polynomial);
        //    int[] coefficients = GetCoefficientsField(actual, "coefficients");

        //    coefficients[0] = 5;
        //    coefficients[1] = -20;
        //    coefficients[2] = 4;


        //    Assert.IsNotNull(actual);
        //    Assert.AreNotEqual(expected, actual);
        //}

        //private static int[] GetCoefficientsField(Polynomial value, string field)
        //{
        //    Type typePolynomial = value.GetType();
        //    FieldInfo coefficientsField = typePolynomial.GetField(field, BindingFlags.NonPublic | BindingFlags.Instance);
        //    return (int[])coefficientsField.GetValue(coefficientsField);
        //}

        [Test]
        public void TestConstructor_Array_Created()
        {
            int[] array = { 0, 1, 2, 3, 4 };
            const int index = 0;
            int expected = array[index];
            Polynomial polynomial = new Polynomial(array);

            array[index] = 12;

            Assert.AreEqual(expected, polynomial[index]);
        }

        [Test]
        public void TestGetHashCode_Polynomial_HeshCode(
            [Values(-9, -1, 0, 1, 9)] int a,
            [Values(-9, -1, 0, 1, 9)] int b,
            [Values(-9, -1, 0, 1, 9)] int c,
            [Values(-9, -1, 0, 1, 9)] int d,
            [Values(-9, -1, 0, 1, 9)] int e,
            [Values(-9, -1, 0, 1, 9)] int f
            )
        {
            int[] firstCoefficients = { a, b, c };
            int[] secondCoefficients = { d, e, f };
            Polynomial first = new Polynomial(firstCoefficients);
            Polynomial second = new Polynomial(secondCoefficients);
            bool expected = first.Equals(second);

            bool actual = first.GetHashCode() == second.GetHashCode();

            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void TestConstructor_Polynomial_Created()
        {
            int[] coefficients = { 1, 2, 3, 4 };
            Polynomial first = new Polynomial(coefficients);
            Polynomial second = new Polynomial(first);
            int index = 0;
            int expected = 1;

            second[index] = 10;

            Assert.AreEqual(expected, first[0]);
        }

        [Test]
        [TestCase(new int[] { 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2 }, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, ExpectedResult = 6)]
        public int TestLength(int[] values)
        {
            Polynomial polynomial = new Polynomial(values);

            return polynomial.Length;
        }

        [Test]
        public void TestEquals_TwoSame_True()
        {
            int[] coefficients = { 1, 2, 3, 4 };
            Polynomial one = new Polynomial(coefficients);
            Polynomial another = new Polynomial(one);

            Assert.IsTrue(one.Equals(another));
        }

        [Test]
        public void TestEquals_TwoDifferent_False()
        {
            int[] firstCoefficients = { 1, 2, 3, 4 };
            Polynomial one = new Polynomial(firstCoefficients);
            int[] secondCoefficients = { 1, 3, 5, 6 };
            Polynomial another = new Polynomial(secondCoefficients);

            Assert.IsFalse(one.Equals(another));
        }

        [Test]
        public void TestEquality_TwoSame_True()
        {
            int[] firstCoefficients = { 1, 2, 3, 4 };
            Polynomial left = new Polynomial(firstCoefficients);
            int[] secondCoefficients = { 1, 2, 3, 4 };
            Polynomial right = new Polynomial(secondCoefficients);

            Assert.IsTrue(left == right);
        }

        [Test]
        public void TestEquality_TwoDifferent_False()
        {
            int[] firstCoefficients = { 1, 2, 3, 4 };
            Polynomial left = new Polynomial(firstCoefficients);
            int[] secondCoefficients = { 8, 2, 3, 4 };
            Polynomial right = new Polynomial(secondCoefficients);

            Assert.IsFalse(left == right);
        }

        [Test]
        public void TestInequality_TwoSame_False()
        {
            int[] firstCoefficients = { 1, 2, 3, 4 };
            Polynomial left = new Polynomial(firstCoefficients);
            int[] secondCoefficients = { 1, 2, 3, 4 };
            Polynomial right = new Polynomial(secondCoefficients);

            Assert.IsFalse(left != right);
        }

        [Test]
        public void TestInequality_TwoDifferent_True()
        {
            int[] firstCoefficients = { 1, 2, 3, 4 };
            Polynomial left = new Polynomial(firstCoefficients);
            int[] secondCoefficients = { 8, 2, 3, 4 };
            Polynomial right = new Polynomial(secondCoefficients);

            Assert.IsTrue(left != right);
        }

        

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 10, 20, 30, 40}, new int[] { 11, 22, 33, 40 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { -1, -2, -3}, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 0 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 0 }, new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 6, 4 })]
        [TestCase(new int[] { 1, 2, 3, 5, 10 }, new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 6, 9, 10 })]
        public void TestAddition(int[] valuesLeft, int[] valuesRight, int[] expectedCoefficients)
        {
            Polynomial left = new Polynomial(valuesLeft);
            Polynomial right = new Polynomial(valuesRight);
            Polynomial expected = new Polynomial(expectedCoefficients);

            Polynomial actual = left + right;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAddition_FirstIsNull_Exception()
        {
            Polynomial left = null;
            int[] coefficients = { 0, 1, 2 };
            Polynomial right = new Polynomial(coefficients);

            void Calculate()
            {
                Polynomial actual = left + right;
            }

            Assert.Throws<ArgumentNullException>(Calculate);
        }

        [Test]
        public void TestAddition_SecondIsNull_Exception()
        { 
            int[] coefficients = { 0, 1, 2 };
            Polynomial left = new Polynomial(coefficients);
            Polynomial right = null;

            void Calculate()
            {
                Polynomial actual = left + right;
            }

            Assert.Throws<ArgumentNullException>(Calculate);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 1, 4, 7, 6 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 1, 2, 3 }, new int[] { 1, 4, 7, 6 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 4, 10, 12, 9 })]
        public void TestMultiplication(int[] valuesLeft, int[] valuesRight, int[] expected)
        {
            Polynomial left = new Polynomial(valuesLeft);
            Polynomial right = new Polynomial(valuesRight);
            Polynomial polynomialExpected = new Polynomial(expected);

            Polynomial actual = left * right;

            Assert.AreEqual(polynomialExpected, actual);
        }

        [Test]
        public void TestToString_023_Success()
        {
            int[] coefficients = { 0, 2, 3 };
            Polynomial polynomial1 = new Polynomial(coefficients);
            string expected = "0X^0 + 2X^1 + 3X^2";

            string actual = polynomial1.ToString();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(new int[] { 0, 2, 3 }, ExpectedResult ="3X^2 + 2X")]
        [TestCase(new int[] { 0, 2, 3, 4 }, ExpectedResult = "4X^3 + 3X^2 + 2X")]
        [TestCase(new int[] {-0 }, ExpectedResult = "0")]
        [TestCase(new int[] {-0, 0 }, ExpectedResult = "0")]
        [TestCase(new int[] { 0, 1 }, ExpectedResult = "X")]
        [TestCase(new int[] { 0, -1 }, ExpectedResult = " - X")]
        [TestCase(new int[] { -1, -1 }, ExpectedResult = " - X - 1")]
        [TestCase(new int[] { -0, 1, -0 }, ExpectedResult = "X")]
        [TestCase(new int[] { 0, -0, -0 }, ExpectedResult = "0")]
        [TestCase(new int[] { 0, -0, -0, -10 }, ExpectedResult = " - 10X^3")]
        [TestCase(new int[] { -15, 0, -0, -0 }, ExpectedResult = " - 15")]
        [TestCase(new int[] { -11, 0, -0, -12 }, ExpectedResult = " - 12X^3 - 11")]
        public string TestToStringSignificantOnly(int[] coefficients)
        {
            Polynomial polynomial1 = new Polynomial(coefficients);
        
            return polynomial1.ToStringSignificantOnly();
        }
    }
}