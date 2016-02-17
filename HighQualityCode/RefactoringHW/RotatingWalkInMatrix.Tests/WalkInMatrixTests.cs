namespace RotatingWalkInMatrix.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WalkInMatrixTests
    {
        [TestMethod]
        public void TestCreateMatrixWthSizeOne()
        {
            int size = 1;

            int[,] matrix = WalkInMatrix.GenerateMatrix(size);

            int[,] expectedResult =
            {
                { 1 }
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Assert.AreEqual(expectedResult[row, col], matrix[row, col]);
                }
            }
        }

        [TestMethod]
        public void TestCreateMatrixWithSizeTwo()
        {
            int size = 2;

            int[,] matrix = WalkInMatrix.GenerateMatrix(size);

            int[,] expectedResult =
            {
                { 1, 4 }, 
                { 3, 2 }
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Assert.AreEqual(expectedResult[row, col], matrix[row, col]);
                }
            }
        }

        [TestMethod]
        public void TestCreateMatrixWithSizeSix()
        {
            int size = 6;

            int[,] matrix = WalkInMatrix.GenerateMatrix(size);

            int[,] expectedResult =
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 36, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 }
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Assert.AreEqual(expectedResult[row, col], matrix[row, col]);
                }
            }
        }
    }
}
