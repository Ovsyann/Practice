using NUnit.Framework;
using MatrixTask;

namespace MatrixTests
{
    public class MatrixTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConstructor()
        {
            int[,] elements = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            
            Matrix matrix = new Matrix(elements);

            Assert.IsNotNull(matrix);
        }
    }
}