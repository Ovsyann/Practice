using System;
using System.Reflection;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using PolynomialTask;


namespace PolynomialTests
{
    public class PolynomialTests
    {
        [Test]
        public void TestConstructor_Incaps_Success()
        {
            int[] expected = { -4, 6, 9 };
            Polynomial polynomial = new Polynomial(expected);


            Polynomial actual = new Polynomial(polynomial);

            Type typePolynomial = typeof(Polynomial);
            FieldInfo coefficientsField =
            typePolynomial.GetField("coefficients", BindingFlags.NonPublic | BindingFlags.Instance);
            int[] coefficients = (int[])coefficientsField.GetValue(actual);

            coefficients[0] = 5;
            coefficients[1] = -20;
            coefficients[2] = 4;


            Assert.IsNotNull(actual);
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        public void TestConstructor_Array_Created()
        {
            int[] array = { 0, 1, 2, 3, 4 };
            Polynomial polynomial = new Polynomial(array);

            array[0] = 12;
            Assert.AreEqual(0, polynomial[0]);
        }

        [Test]
        [TestCase(new int[] {-9 },ExpectedResult = -9)]
        [TestCase(new int[] { -1 }, ExpectedResult = -1)]
        [TestCase(new int[] { 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 9 }, ExpectedResult = 9)]
        public int TestGetHashCode_Polynomial_HeshCode(int[] array)
        {
            Polynomial polynomial = new Polynomial(array);
            return polynomial.GetHashCode();
        }

        [Test]
        public void TestConstructor_Polynomial_Created()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = new Polynomial(array);
            Polynomial polynomial2 = new Polynomial(polynomial1);
            int expected = 1;

            polynomial2[0] = 10;

            Assert.AreEqual(expected, polynomial1[0]);
        }

        [Test]
        [TestCase(new int[] {1,2,3,4,5},ExpectedResult = 5)]
        public int TestLength_5elements_5(int[] values)
        {
            
            Polynomial polynomial = new Polynomial(values);


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
            Polynomial polynomial = new Polynomial(values);

            Assert.AreEqual(expected, polynomial.Length);
        }

        [Test]
        public void TestEquals_TwoSame_True()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = new Polynomial(array);
            Polynomial polynomial2 = new Polynomial(polynomial1);

            Assert.IsTrue(polynomial1.Equals(polynomial2));
        }

        [Test]
        public void TestEquals_TwoDifferent_False()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = new Polynomial(array);
            int[] array2 = { 1, 3, 5, 6 };
            Polynomial polynomial2 = new Polynomial(array2);

            Assert.IsFalse(polynomial1.Equals(polynomial2));
        }

        [Test]
        public void TestOverridenEquality_TwoSame_True()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = new Polynomial(array);
            int[] array2 = { 1, 2, 3, 4 };
            Polynomial polynomial2 = new Polynomial(array2);

            Assert.IsTrue(polynomial1 == polynomial2);
        }

        [Test]
        public void TestOverridenEquality_TwoDifferent_False()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = new Polynomial(array);
            int[] array2 = { 8, 2, 3, 4 };
            Polynomial polynomial2 = new Polynomial(array2);

            Assert.IsFalse(polynomial1 == polynomial2);
        }

        [Test]
        public void TestOverridenNonEquality_TwoSame_False()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = new Polynomial(array);
            int[] array2 = { 1, 2, 3, 4 };
            Polynomial polynomial2 = new Polynomial(array2);

            Assert.IsFalse(polynomial1 != polynomial2);
        }

        [Test]
        public void TestOverridenNonEquality_TwoDifferent_True()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial1 = new Polynomial(array);
            int[] array2 = { 8, 2, 3, 4 };
            Polynomial polynomial2 = new Polynomial(array2);

            Assert.IsTrue(polynomial1 != polynomial2);
        }

        

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 6, 4 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 })]
        [TestCase(new int[] { 1, 2, 3, 0 }, new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 6, 4 })]
        [TestCase(new int[] { 1, 2, 3, 5, 10 }, new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 6, 9, 10 })]
        public void TestOverridenSummary_TwoPolyninomials_Calculated(int[] valuesLeft, int[] valuesRight, int[] expected)
        {
            Polynomial polynomial1 = new Polynomial(valuesLeft);
            Polynomial polynomial2 = new Polynomial(valuesRight);
            Polynomial polynomialExpected = new Polynomial(expected);

            Polynomial actual = polynomial1 + polynomial2;

            Assert.AreEqual(polynomialExpected, actual);
        }

        [Test]
        public void TestOverridenSummary_FirstIsNull_Exception()
        {
            Polynomial polynomial1 = null;
            int[] array = { 0, 1, 2 };
            Polynomial polynomial2 = new Polynomial(array);

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
            Polynomial polynomial1 = new Polynomial(array);
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
            Polynomial polynomial1 = new Polynomial(array);
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
        public string TestToStringSignificant_023_Success(int[] odds)
        {
            Polynomial polynomial1 = new Polynomial(odds);
        

            return polynomial1.ToStringSignificant();
        }
    }
}