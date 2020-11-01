using NUnit.Framework;
using PolynomialTask;

namespace PolynomialTests
{
    public class PolynomialTests
    {
        [Test]
        public void TestTryCreate_Array_Created()
        {
            int[] array = { 1, 2, 3, 4 };
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

            polynomial1.Odds[0] = 5;

            Assert.AreEqual(expected, polynomial2[0]);
        }

        [Test]
        public void TestLength_4elements_4()
        {
            int[] array = { 1, 2, 3, 4 };
            Polynomial polynomial = Polynomial.TryCreate(array);
            int expected = 4;

            Assert.AreEqual(expected, polynomial.Length);
        }

        [Test]
        public void TestGetHashCode_1and2and3_Calculated()
        {
            int[] array = { 1, 2, 3 };
            Polynomial polynomial = Polynomial.TryCreate(array);
            int expected = 60;

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
        public void TestOverridenSummary_123And123_Calculated()
        {
            int[] array = { 1, 2, 3 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            int[] array2 = { 1, 2, 3 };
            Polynomial polynomial2 = Polynomial.TryCreate(array2);
            int[] array3 = { 2, 4, 6 };
            Polynomial expected = Polynomial.TryCreate(array3);

            Polynomial actual = polynomial1 + polynomial2;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestOverridenSummary_123And1234_Calculated()
        {
            int[] array = { 1, 2, 3 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            int[] array2 = { 1, 2, 3, 4 };
            Polynomial polynomial2 = Polynomial.TryCreate(array2);
            int[] array3 = { 2, 4, 6, 4 };
            Polynomial expected = Polynomial.TryCreate(array3);

            Polynomial actual = polynomial1 + polynomial2;

            Assert.AreEqual(expected, actual);
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
        public void TestToStringSignificant_023_Success()
        {
            int[] array = { 0, 2, 3 };
            Polynomial polynomial1 = Polynomial.TryCreate(array);
            string expected = "3X^2 + 2X";

            string actual = polynomial1.ToStringSignificant();

            Assert.AreEqual(expected, actual);
        }
    }
}