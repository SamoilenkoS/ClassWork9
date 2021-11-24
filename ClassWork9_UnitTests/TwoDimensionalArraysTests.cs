using LibraryForClassWork;
using NUnit.Framework;

namespace ClassWork9_UnitTests
{
    public class TwoDimensionalArraysTests
    {
        [TestCaseSource(nameof(MinICases))]
        public void MinI_WhenFilledArrayPassed_ShouldGetMinIndexes
            (int[,] array, (int, int) expectedResult)
        {
            var actualResult = TwoDimensionalArraysHelper.MinI(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] MinICases =
        {
            new object[]{
                new int[,]{ { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } },
                (0, 2)
            },
            new object[]{
                new int[,]{ { 4, 5, 6 }, { 3, 1, 2 } },
                (1, 1)
            }
        };
    }
}